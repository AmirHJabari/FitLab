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

namespace FitLab.ServicesTransactions
{
    public partial class frmServicesTransactions : Form
    {
        private bool _isFilter;
        public frmServicesTransactions()
        {
            InitializeComponent();
            cmbIsPaid.SelectedIndex = 0;
            cmbService.SelectedIndex = 0;
            _isFilter = false;
            dgvTransactions.AutoGenerateColumns = false;
        }

        private async Task BindGridAsync(bool doFilters)
        {
            btnRefresh.Enabled = false;
            btnFilter.Enabled = false;

            List<ServicesTransaction> transactions;
            List<Customer> customers;
            ServicesTransactionFields fields = new ServicesTransactionFields()
            {
                CustomerID = true,
                Date = true,
                Goodses = true,
                ServiceID = true,
                Price = true,
                IsPaid = true,
                PaidPrice = true
            };

            DateTime? startDate = null;
            DateTime? endDate = null;
            bool? isPaid = null;
            int serviceID = 0;
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
                serviceID = cmbService.SelectedIndex;
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
                    transactions = await db.ServicesTransactions.AdvancedSearchTransactionAsync(isPaid, fields);
                    transactions = transactions.Where(t => customers.Any(c => c.CustomerID == t.CustomerID)).ToList();
                    if (serviceID != 0)
                        transactions = transactions.Where(t => t.ServiceID == serviceID).ToList();

                    if (startDate != null)
                        transactions = transactions.Where(t => t.Date.Date >= startDate.Value.Date).ToList();
                    if (endDate != null)
                        transactions = transactions.Where(t => t.Date.Date <= endDate.Value.Date).ToList();
                }
                else
                    transactions = await db.ServicesTransactions.GetAllAsync(fields);

                // order by newer
                transactions = transactions.OrderByDescending(t => t.Date).ToList();

                dgvTransactions.Rows.Clear();

                await FillGrid(transactions, db);
            }

            btnRefresh.Enabled = true;
            btnFilter.Enabled = true;
        }

        private Task FillGrid(List<ServicesTransaction> transactions, FitLabDB db)
        {
            return Task.Run(() =>
            {
                foreach (var data in transactions)
                {
                    var transaction = new
                    {
                        data.ID,
                        data.CustomerID,
                        FullName = db.Customers.GetNameByID(data.CustomerID),
                        data.ServiceID,
                        ServiceName = StaticTables.GymServices.Find(s => s.ServiceID == data.ServiceID).Name,
                        data.Goodses,
                        Date = data.Date.ToShamsi(),
                        data.Price,
                        data.IsPaid,
                        Remaining = (data.Price - data.PaidPrice).Separate()
                    };

                    try
                    {
                        dgvTransactions.Invoke(new Action(() =>
                            {
                                // fill data grid view
                                dgvTransactions.Rows.Add(transaction.ID, transaction.CustomerID, transaction.FullName,
                                        transaction.ServiceID, transaction.ServiceName, transaction.Goodses, transaction.Date, transaction.Price,
                                        transaction.IsPaid, transaction.Remaining);
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
                case (Keys.Control | Keys.A):
                    btnAdd.PerformClick();
                    return true;
                case (Keys.Control | Keys.E):
                    btnEdit.PerformClick();
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
                    dgvTransactions.Focus();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void FrmServicesTransactions_Load(object sender, EventArgs e)
        {
            _isFilter = false;
            txtDateFrom.Text = $"{DateTime.Now.PersianYear().ToString("0000")}-{DateTime.Now.PersianMonth().ToString("00")}-01";
            //txtDateFrom.Text = "1399-08-01";
            await BindGridAsync(true);
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

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddOrEditeTransactions frmAddTransaction = new frmAddOrEditeTransactions())
            {
                var result = frmAddTransaction.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    await BindGridAsync(_isFilter);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show(this, "مشکلی پیش آمد!", "خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow != null)
            {
                int transactionID = Convert.ToInt32(dgvTransactions.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditeTransactions frmEditTransaction = new frmAddOrEditeTransactions(true, transactionID);
                ShowSubForms(frmEditTransaction);
            }
            else
            {
                MessageBox.Show("لطفا تراکنشی را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            _isFilter = false;
            await BindGridAsync(false);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow != null)
            {
                int transactionID = int.Parse(dgvTransactions.CurrentRow.Cells[0].Value.ToString());

                string name = dgvTransactions.CurrentRow.Cells[2].Value.ReturnEmptyIfItsNull();
                if (MessageBox.Show(this, $"آیا از حذف این تراکنش مطمئن هستید؟", name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (FitLabDB db = new FitLabDB())
                    {
                        db.ServicesTransactions.Delete(transactionID);
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

        private async void BtnFilter_Click(object sender, EventArgs e)
        {
            _isFilter = true;
            await BindGridAsync(_isFilter);
        }

        private void TxtDateFrom_MouseUp(object sender, MouseEventArgs e)
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

        private void TxtDateFrom_Enter(object sender, EventArgs e)
        {
            MaskedSetCursorPosition((MaskedTextBox)sender);
        }
    }
}
