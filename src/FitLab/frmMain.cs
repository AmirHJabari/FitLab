using FitLab.DataLayer.Models.SelectedFields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitLab.Customers;
using FitLab.GymTimes;
using FitLab.DataLayer;
using FitLab.DataLayer.Models;
using FitLab.Utilities;
using FitLab.ServicesTransactions;
using FitLab.Business;
using FitLab.Settings;

namespace FitLab
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.TopLevel = true;
        }
        private async Task BindGridAsync()
        {
            await BindAccounting();
            List<GymTime> dataSource;
            using (FitLabDB db = new FitLabDB())
            {
                dataSource = await db.GymTimes.GetOpenTimesAsync(new GymTimeFields()
                {
                    CustomerID = true,
                    DateAndTime = true,
                    BoxCode = true,
                    Price = true,
                    Description = true
                });

                //  order by newer
                dataSource = dataSource.OrderByDescending(t => t.DateAndTime).ToList();

                dgvOpenTimes.Rows.Clear();

                await FillGrid(dataSource, db);
                //foreach (var data in dataSource)
                //{
                //    // fill data grid view
                //    dgvOpenTimes.Rows.Add(data.ID, db.Customers.GetNameByID(data.CustomerID), data.DateAndTime.TimeOfDay,
                //        data.BoxCode, data.Price.Separate(), data.Description);
                //}
            }
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
                        CustomerName = db.Customers.GetNameByID(data.CustomerID),
                        data.DateAndTime.TimeOfDay,
                        data.BoxCode,
                        Price = data.Price.Separate(),
                        data.Description
                    };

                    dgvOpenTimes.Invoke(new Action(() =>
                    {
                        // fill data grid view
                        dgvOpenTimes.Rows.Add(time.ID, time.CustomerName, time.TimeOfDay, time.BoxCode, time.Price, time.Description);
                    }));

                }
            });
        }


        private async Task BindAccounting()
        {
            lblTodayCash.Text = (await Accounting.GetTodayCashAsync()).Separate();
            lblTodayDemand.Text = (await Accounting.GetTodayDemandAsync()).Separate();

            lblThisWeekCash.Text = (await Accounting.GetThisWeekCashAsync()).Separate();
            lblThisWeekDemand.Text = (await Accounting.GetThisWeekDemandAsync()).Separate();

            lblThisMonthCash.Text = (await Accounting.GetThisMonthCashAsync()).Separate();
            lblThisMonthDemand.Text = (await Accounting.GetThisMonthDemandAsync()).Separate();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaticTables.GymRulesAndProperties.GymName) || string.IsNullOrEmpty(StaticTables.GymRulesAndProperties.OwnerName))
            {
                this.Hide();

                MessageBox.Show(".سلام به  فیتلب خوش آمدید\n" +
                    "فیتلب یک اپلیکیشن دسکتاپ است که برای راحت تر مدیریت کردن .باشگاها طراحی شده است\n" +
                    ".توجه تمامی مبالغ را به تومان وارد کنید\n" +
                    "(: حالا با دقت فرم بعدی رو پر کنید",
                    "توجه", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                frmGymRulesAndProperties rulesAndProperties = new frmGymRulesAndProperties();
                DialogResult result = rulesAndProperties.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("این اطلاعات را بعدا میتوانید از قسمت تنظیمات تغییر دهید.", "توجه", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    this.Show();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("مشکلی پیش آمد", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
            }
            await BindGridAsync();
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Console.WriteLine("_________________________________________________\n\n");
            Console.WriteLine(keyData.ToString());
            Console.WriteLine(msg);
            Console.WriteLine(msg.Msg);
            Console.WriteLine("\n_________________________________________________\n\n");
            switch (keyData)
            {
                case (Keys.Control | Keys.V | Keys.A):
                    MessageBox.Show("Hello World!");
                    return true;
                //case (Keys.Control | Keys.A):
                //    btnNewTime.PerformClick();
                //    return true;
                case (Keys.Control | Keys.E):
                    btnEditTime.PerformClick();
                    return true;
                case (Keys.Control | Keys.D):
                    btnDeleteTime.PerformClick();
                    return true;
                case (Keys.Control | Keys.R):
                    btnRefreshTimeGrid.PerformClick();
                    return true;
                case (Keys.Control | Keys.C):
                    btnCloseTime.PerformClick();
                    return true;
                case (Keys.Control | Keys.Shift | Keys.C):
                    btnCustomers.PerformClick();
                    return true;
                case (Keys.Control | Keys.Shift | Keys.T):
                    btnGymTimes.PerformClick();
                    return true;
                case (Keys.Control | Keys.T):
                    btnTransactions.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private async void ShowSubForms(Form form)
        {
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                await BindGridAsync();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(this, "مشکلی پیش آمد!", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            form.Dispose();
        }

        private async void BtnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            this.Hide();
            ShowSubForms(frmCustomers);
            this.Show();
            await BindGridAsync();
            await BindAccounting();
        }
        private async void BtnGymTimes_Click(object sender, EventArgs e)
        {
            frmGymTimes gymTimes = new frmGymTimes();
            this.Hide();
            ShowSubForms(gymTimes);
            this.Show();
            await BindAccounting();
        }
        private void BtnNewTime_Click(object sender, EventArgs e)
        {
            frmAddOrEditGymTime frmAddGymTime = new frmAddOrEditGymTime();
            ShowSubForms(frmAddGymTime);
        }
        private void BtnEditTime_Click(object sender, EventArgs e)
        {
            if (dgvOpenTimes.CurrentRow != null)
            {
                int timeID = Convert.ToInt32(dgvOpenTimes.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditGymTime frmEditGymTime = new frmAddOrEditGymTime(true, timeID);
                ShowSubForms(frmEditGymTime);
            }
            else
            {
                MessageBox.Show("لطفا تایمی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }
        private async void BtnRefreshTimeGrid_Click(object sender, EventArgs e)
        {
            btnRefreshTimeGrid.Enabled = false;
            await BindGridAsync();
            btnRefreshTimeGrid.Enabled = true;
        }
        private async void BtnDeleteTime_Click(object sender, EventArgs e)
        {
            if (dgvOpenTimes.CurrentRow != null)
            {
                int timeID = int.Parse(dgvOpenTimes.CurrentRow.Cells[0].Value.ToString());

                string name = dgvOpenTimes.CurrentRow.Cells[1].Value.ReturnEmptyIfItsNull();
                if (MessageBox.Show(this, $"آیا از حذف این تایم مطمئن هستید؟", name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (FitLabDB db = new FitLabDB())
                    {
                        db.GymTimes.Delete(timeID);
                    }
                    await BindGridAsync();
                }
            }
            else
            {
                MessageBox.Show("لطفا تایمی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }
        private void BtnCloseTime_Click(object sender, EventArgs e)
        {

            if (dgvOpenTimes.CurrentRow != null)
            {
                int timeID = int.Parse(dgvOpenTimes.CurrentRow.Cells[0].Value.ToString());

                string name = dgvOpenTimes.CurrentRow.Cells[1].Value.ReturnEmptyIfItsNull();
                frmCloseGymTimes closeTime = new frmCloseGymTimes(name, timeID);
                ShowSubForms(closeTime);
            }
            else
            {
                MessageBox.Show("لطفا تایمی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private async void BtnTransactions_Click(object sender, EventArgs e)
        {
            frmServicesTransactions frmTransactions = new frmServicesTransactions();
            this.Hide();
            ShowSubForms(frmTransactions);
            this.Show();
            await BindAccounting();
        }

        private void GymInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGymRulesAndProperties rulesAndProperties = new frmGymRulesAndProperties();
            DialogResult result = rulesAndProperties.ShowDialog(this);
            if (result == DialogResult.OK)
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == DialogResult.No)
                MessageBox.Show("مشکلی پیش آمد", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
