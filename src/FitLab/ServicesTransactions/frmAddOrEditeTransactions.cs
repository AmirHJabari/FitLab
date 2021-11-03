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
    public partial class frmAddOrEditeTransactions : Form
    {
        private ServicesTransaction _transaction;
        private bool _editMode = false;
        public frmAddOrEditeTransactions(bool editMode = false, int transactionID = -1)
        {
            InitializeComponent();
            if (editMode && transactionID != -1)
            {
                _editMode = true;
                this.Text = "ویرایش تراکنش";
                btnSubmit.Text = "ویرایش";
                using (FitLabDB db = new FitLabDB())
                    _transaction = db.ServicesTransactions.GetByID(transactionID);

                cmbService.SelectedIndex = _transaction.ServiceID - 1;
                txtGoodses.Text = _transaction.Goodses;
                txtDescription.Text = _transaction.Description;
                numPrice.Value = _transaction.Price;
                numPaidPrice.Value = _transaction.PaidPrice;
                rbtnPaid.Checked = _transaction.IsPaid;
            }
            else if (!editMode && transactionID == -1)
            {
                cmbService.SelectedIndex = 0;
                numPrice.Value = 5000;
                _transaction = new ServicesTransaction();
                numPrice.Value = StaticTables.GymRulesAndProperties.DefaultPriceForGymTime;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private async void FrmAddOrEditeTransactions_Load(object sender, EventArgs e)
        {
            await BindGridAsync();

            //focus on the customer of _gymTime if it's edit mode
            if (_editMode)
            {
                txtSearch.Text = _transaction.CustomerID.ToString();
                for (int i = 0; i < dgvCustomers.Rows.Count; i++)
                {
                    var item = dgvCustomers.Rows[i];

                    if (Convert.ToInt32(item.Cells[0].Value.ToString()) == _transaction.CustomerID)
                    {
                        dgvCustomers.CurrentCell = item.Cells[2];
                        item.Selected = true;
                        return;
                    }
                }
            }
        }
        private async Task BindGridAsync()
        {
            List<Customer> dataSource;
            using (FitLabDB db = new FitLabDB())
            {
                dataSource = await db.Customers.GetAllAsync(new CustomerFields()
                {
                    FullName = true,
                    Debt = true
                });
            }
            foreach (var data in dataSource)
            {
                // fill data grid view
                dgvCustomers.Rows.Add(data.CustomerID, data.FullName, data.Debt.Separate());
            }
        }



        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();
            List<Customer> dataSource;
            using (FitLabDB db = new FitLabDB())
            {
                dataSource = await db.Customers.SearchAsync(txtSearch.Text, new CustomerFields()
                {
                    FullName = true,
                    Debt = true
                });
            }
            foreach (var data in dataSource)
            {
                dgvCustomers.Rows.Add(data.CustomerID, data.FullName, data.Debt.Separate());
            }
        }

        private void DgvCustomers_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                txtCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show(this, ".لطفا شخصی را از لیست انتخاب کنید", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            _transaction.CustomerID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
            _transaction.Description = txtDescription.Text;
            _transaction.Goodses = txtGoodses.Text;
            _transaction.IsPaid = rbtnPaid.Checked;
            _transaction.PaidPrice = (long)numPaidPrice.Value;
           _transaction.ServiceID = cmbService.SelectedIndex + 1;
            _transaction.Price = (long)numPrice.Value;
            bool resualt;

            if (_editMode)
            {
                using (FitLabDB db = new FitLabDB())
                    resualt = db.ServicesTransactions.Update(_transaction);
            }
            else
            {
                _transaction.Date = DateTime.Now.Date;
                // for (int i = 0; i < 1000; i++)
                //{
                    using (FitLabDB db = new FitLabDB())
                        resualt = db.ServicesTransactions.Insert(_transaction);

                //}
            }

            if (resualt)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void NumPrice_ValueChanged(object sender, EventArgs e)
        {
            numPaidPrice.Maximum = numPrice.Value;

            if (rbtnPaid.Checked)
                numPaidPrice.Value = numPrice.Value;
        }

        private void RbtnPaid_CheckedChanged(object sender, EventArgs e)
        {
            numPaidPrice.Enabled = false;
            numPaidPrice.Value = numPrice.Value;
        }

        private void RbtnNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            numPaidPrice.Enabled = true;
            numPaidPrice.Value = 0;
        }

        private void NumPaidPrice_ValueChanged(object sender, EventArgs e)
        {
            if (numPrice.Value <= ((long)numPaidPrice.Value))
            {
                rbtnPaid.Checked = true;
            }
        }
    }
}
