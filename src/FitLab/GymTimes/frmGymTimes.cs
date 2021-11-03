using FitLab.DataLayer;
using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using FitLab.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLab.GymTimes
{
    public partial class frmGymTimes : Form
    {
        private bool _isFilter;
        public frmGymTimes()
        {
            InitializeComponent();
            cmbIsPaid.SelectedIndex = 0;
            _isFilter = false;
        }

        private async Task BindGridAsync(bool doFilters)
        {
            btnRefresh.Enabled = false;
            btnFilter.Enabled = false;

            List<GymTime> times;
            List<Customer> customers;
            GymTimeFields fields = new GymTimeFields()
            {
                CustomerID = true,
                DateAndTime = true,
                Length = true,
                BoxCode = true,
                Price = true,
                IsPaid = true,
                PaidPrice = true
            };

            DateTime? startDate = null;
            DateTime? endDate = null;
            bool? isPaid = null;
            if (doFilters)
            {
                switch (cmbIsPaid.SelectedIndex)
            {
                case 0:
                    isPaid = null;
                    break;
                case 1:
                    isPaid = true;
                    break;
                case 2:
                    isPaid = false;
                    break;
            }
                if (!txtDateFrom.Text.Equals("    -  -"))
                {
                    try
                    {
                        startDate = MyConverter.ToGregorianDate(txtDateFrom.Text);
                    }
                    catch
                    {
                        MessageBox.Show("لطفا یک تاریخ صحیح و معتبر را برای \"از تاریخ\" وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDateFrom.Focus();
                        return;
                    }
                }

                if (!txtDateTo.Text.Equals("    -  -"))
                {
                    try
                    {
                        endDate = MyConverter.ToGregorianDate(txtDateTo.Text);
                    }
                    catch
                    {
                        MessageBox.Show("لطفا یک تاریخ صحیح و معتبر را برای \"تا تاریخ\" وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDateTo.Focus();
                        return;
                    }
                }
            }

            using (FitLabDB db = new FitLabDB())
            {
                if (doFilters)
                {
                    customers = await db.Customers.SearchAsync(txtSearch.Text, new CustomerFields());
                    times = await db.GymTimes.AdvancedSearchTimesAsync(false, isPaid, fields);
                    times = times.Where(t=> customers.Any(c=> c.CustomerID == t.CustomerID)).ToList();

                    if (startDate != null)
                        times = times.Where(t=> t.DateAndTime.Date >= startDate.Value.Date).ToList();
                    if (endDate != null)
                        times = times.Where(t => t.DateAndTime.Date <= endDate.Value.Date).ToList();
                }
                else
                    times = await db.GymTimes.GetCloseTimesAsync(fields);

                // order by newer
                times = times.OrderByDescending(t=> t.DateAndTime).ToList();

                dgvCloseTimes.Rows.Clear();

                await FillGrid(times, db);
            }

            btnRefresh.Enabled = true;
            btnFilter.Enabled = true;
        }

        private Task FillGrid(List<GymTime> times, FitLabDB db)
        {
            return Task.Run(() =>
            {
                foreach (var data in times)
                {
                    var time = new
                    {
                        data.ID,
                        data.CustomerID,
                        FullName = db.Customers.GetNameByID(data.CustomerID),
                        DateAndTime = data.DateAndTime.ToShamsi(),
                        Length = data.Length.TimeOfDay,
                        data.BoxCode,
                        Price = data.Price.Separate(),
                        data.IsPaid,
                        Remaining = (data.Price - data.PaidPrice).Separate()
                    };

                    try
                    {
                        dgvCloseTimes.Invoke(new Action(() =>
                        {
                            // fill data grid view
                            dgvCloseTimes.Rows.Add(time.ID, time.CustomerID, time.FullName, time.DateAndTime, time.Length,
                                time.BoxCode, time.Price, time.IsPaid, time.Remaining);
                        }));
                    }
                    catch
                    {
                        return;
                    }
                }
            });
        }





        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.I):
                    btnInfo.PerformClick();
                    return true;
                case (Keys.Control | Keys.X):
                    btnPay.PerformClick();
                    return true;
                case (Keys.Control | Keys.D):
                    btnDelete.PerformClick();
                    return true;
                case (Keys.Control | Keys.R):
                    btnRefresh.PerformClick();
                    return true;
                case (Keys.Control | Keys.S):
                    txtSearch.Focus();
                    return true;
                case (Keys.Control | Keys.L):
                    dgvCloseTimes.Focus();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void FrmGymTimes_LoadAsync(object sender, EventArgs e)
        {
            _isFilter = false;
            txtDateFrom.Text = $"{ DateTime.Now.PersianYear().ToString("0000") }-{ DateTime.Now.PersianMonth().ToString("00") }-01";

            await BindGridAsync(true);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCloseTimes.CurrentRow != null)
            {
                if (!(bool)dgvCloseTimes.CurrentRow.Cells[7].Value)
                {
                    MessageBox.Show("این تایم هنوز تسویه نشده شما نمی توانید آن را حذف کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    return;
                }

                int timeID = int.Parse(dgvCloseTimes.CurrentRow.Cells[0].Value.ToString());

                string name = dgvCloseTimes.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show(this, $"آیا از حذف این تایم مطمئن هستید؟" 
                    +"\nبا این کار بدهی مانده او هم تسویه میشود"
                    , name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)  ==  DialogResult.Yes)
                {
                    using (FitLabDB db = new FitLabDB())
                    {
                        if (!(bool)dgvCloseTimes.CurrentRow.Cells[7].Value)
                        {
                            var time = db.GymTimes.GetByID(timeID);
                            long remaining = time.PaidPrice - time.Price;
                        }
                        db.GymTimes.Delete(timeID);
                    }
                    await BindGridAsync(_isFilter);
                }
            }
            else
            {
                MessageBox.Show("لطفا تایمی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }
        private async void ShowSubForms(Form form)
        {
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                await BindGridAsync(_isFilter);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(this, "مشکلی پیش آمد!", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            form.Dispose();
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            if(dgvCloseTimes.CurrentRow != null)
            {
                if((bool) dgvCloseTimes.CurrentRow.Cells[7].Value)
                {
                    MessageBox.Show("این تایم از قبل تسویه شده", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    return;
                }


                int timeID = int.Parse(dgvCloseTimes.CurrentRow.Cells[0].Value.ToString());

                string name = dgvCloseTimes.CurrentRow.Cells[2].Value.ReturnEmptyIfItsNull();
                frmPayGymTime payGymTime = new frmPayGymTime(name, timeID);
                ShowSubForms(payGymTime);
            }
            else
            {
                MessageBox.Show("لطفا تایمی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            _isFilter = false;
            await BindGridAsync(false);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (dgvCloseTimes.CurrentRow != null)
            {
                int timeID = int.Parse(dgvCloseTimes.CurrentRow.Cells[0].Value.ToString());

                using (frmShowDescription edit = new frmShowDescription(timeID))
                {
                    if (edit.ShowDialog(this) == DialogResult.No)
                    {
                        MessageBox.Show(this, "مشکلی پیش آمد!", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا تایمی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private async void BtnFilter_Click(object sender, EventArgs e)
        {
            _isFilter = true;
            await BindGridAsync(true);
        }

        private void TxtDateTo_MouseUp(object sender, MouseEventArgs e)
        {
            MaskedSetCursorPosition((MaskedTextBox)sender);
        }

        private void TxtDateTo_Enter(object sender, EventArgs e)
        {
            MaskedSetCursorPosition((MaskedTextBox)sender);
        }

        private void MaskedSetCursorPosition(MaskedTextBox txtbox)
        {
            if (txtbox.Text == "    -  -")
            {
                txtbox.SelectionLength = 0;
                txtbox.SelectionStart = 0;
            }
        }
    }
}
