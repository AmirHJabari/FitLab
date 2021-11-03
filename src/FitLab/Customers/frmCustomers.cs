using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitLab.DataLayer;
using FitLab.Utilities;
using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using System.Threading;

namespace FitLab.Customers
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            dgvCustomers.AutoGenerateColumns = false;
            cmbDebtState.SelectedIndex = 0;
        }

        private async void FrmCustomers_Load(object sender, EventArgs e)
        {
            await BindGridAsync();
        }
        private async Task BindGridAsync()
        {
            btnRefresh.Enabled = false;
            btnFilter.Enabled = false;
            List<Customer> dataSource;

            CustomerFields fields = new CustomerFields()
            {
                FullName = true,
                PhoneNumber = true,
                BirthDate = true,
                SignDate = true,
                Debt = true
            };

            using (FitLabDB db = new FitLabDB())
            {
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    dataSource = await db.Customers.GetAllAsync(fields);
                }
                else
                {
                    dataSource = await db.Customers.SearchAsync(txtSearch.Text, fields);
                }
            }

            dataSource = FilterListAsDebtState(dataSource);

            dgvCustomers.Rows.Clear();

            await FillGrid(dataSource);

            btnRefresh.Enabled = true;
            btnFilter.Enabled = true;
        }

        private Task FillGrid(List<Customer> customers)
        {
            return Task.Run(() =>
            {
                foreach (var data in customers)
                {
                    string birthDate = data.BirthDate.ToShamsi();
                    string signDate = data.SignDate.ToShamsi();
                    try
                    {
                        dgvCustomers.Invoke(new Action(() =>
                        {
                            // fill data grid view
                            dgvCustomers.Rows.Add(data.CustomerID, data.FullName, data.PhoneNumber, birthDate, signDate, data.Debt.Separate());
                        }));
                    }
                    catch
                    {
                        return;
                    }
                }
            });
        }

        private List<Customer> FilterListAsDebtState(List<Customer> customers)
        {
            switch (cmbDebtState.SelectedIndex)
            {
                case 0:
                    return customers;
                case 1:
                    return customers.Where(c => c.Debt > 0).ToList();
                case 2:
                    return customers.Where(c => c.Debt == 0).ToList();
                default:
                    throw new Exception();
            }
        }
        private bool IsOthers(int customerID)
        {
            if (customerID == 1)
            {
                MessageBox.Show("شما نمیتوانید بر روی متفرقه تغییری اعمال کنید.", "توجه!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return true;
            }
            else
            {
                return false;
            }
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbDebtState.SelectedIndex = 0;
            await BindGridAsync();
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer();
            DialogResult result = frmAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                await BindGridAsync();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(this, "مشکلی پیش آمد!", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            frmAdd.Dispose();
        }

        private async void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerID = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                if (IsOthers(customerID))
                {
                    return;
                }

                frmAddOrEditCustomer frmEdit = new frmAddOrEditCustomer(true, customerID);
                DialogResult result = frmEdit.ShowDialog();

                if (result == DialogResult.OK)
                {
                    await BindGridAsync();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show(this, "مشکلی پیش آمد!", "خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                frmEdit.Dispose();
            }
            else
            {
                MessageBox.Show("لطفا شخصی را از لیست انتخاب کنید!", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private async void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerID = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                if (IsOthers(customerID))
                {
                    return;
                }

                string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"آیا از حذف این شخص مطمئن هستید؟", name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (FitLabDB db = new FitLabDB())
                    {
                        bool hasTime = db.Customers.HasGymTime(customerID);
                        bool hasTransaction = db.Customers.HasTransaction(customerID);
                        if (hasTime || hasTransaction)
                        {
                            var resualt = MessageBox.Show("این شخص دارای تایم و تراکنش هایی است\n" +
                                "آیا میخواهید پس از حذف آنها را به متفرقه انتقال دهید؟", name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            switch (resualt)
                            {
                                case DialogResult.Cancel:
                                    return;

                                case DialogResult.Yes:
                                    {
                                        if (hasTime)
                                            db.GymTimes.ChangeCustomer(customerID, 1);
                                        if (hasTransaction)
                                            db.ServicesTransactions.ChangeCustomer(customerID, 1);
                                        break;
                                    }

                                case DialogResult.No:
                                    {
                                        if (hasTime)
                                            db.GymTimes.DeleteAllByCustomerID(customerID);
                                        if (hasTransaction)
                                            db.ServicesTransactions.DeleteAllByCustomerID(customerID);
                                        break;
                                    }

                                default:
                                    return;
                            }
                        }
                        db.Customers.Delete(customerID);
                    }
                    await BindGridAsync();
                }
            }
            else
            {
                MessageBox.Show("لطفا شخصی را از لیست انتخاب کنید!", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.A):
                    btnAddCustomer.PerformClick();
                    return true;
                case (Keys.Control | Keys.E):
                    btnEditCustomer.PerformClick();
                    return true;
                case (Keys.Control | Keys.D):
                    btnDeleteCustomer.PerformClick();
                    return true;
                case (Keys.Control | Keys.R):
                    btnRefresh.PerformClick();
                    return true;
                case (Keys.Control | Keys.S):
                    txtSearch.Focus();
                    return true;
                case (Keys.Control | Keys.L):
                    dgvCustomers.Focus();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void BtnFilter_Click(object sender, EventArgs e)
        {
            await BindGridAsync();
        }
    }
}
