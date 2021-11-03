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
using FitLab.DataLayer.Models;
using FitLab.Utilities;
using FitLab.DataLayer.Models.SelectedFields;

namespace FitLab.GymTimes
{
    public partial class frmAddOrEditGymTime : Form
    {
        private GymTime _gymTime;
        private bool _editMode = false;
        public frmAddOrEditGymTime(bool editMode = false, int gymTimeID = -1)
        {
            InitializeComponent();

            if (editMode && gymTimeID != -1)
            {
                _editMode = true;
                this.Text = "ویرایش تایم";
                btnSubmit.Text = "ویرایش";
                using (FitLabDB db = new FitLabDB())
                    _gymTime = db.GymTimes.GetByID(gymTimeID);

                txtBoxCode.Text = _gymTime.BoxCode;
                txtDescription.Text = _gymTime.Description;
                numPrice.Value = _gymTime.Price;
            }
            else if (!editMode && gymTimeID == -1)
            {
                _gymTime = new GymTime();
                numPrice.Value = StaticTables.GymRulesAndProperties.DefaultPriceForGymTime;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private async void BtnFilter_Clicked(object sender, EventArgs e)
        {
            await BindGridAsync(true);
        }

        private async void FrmAddOrEditGymTime_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                txtSearch.Text = _gymTime.CustomerID.ToString();
                Customer customer;
                using (FitLabDB db = new FitLabDB())
                {
                    customer = db.Customers.GetByID(_gymTime.CustomerID);
                }

                // Add the currnet customer to DGV
                dgvCustomers.Rows.Add(customer.CustomerID, customer.FullName, customer.Debt.Separate());
            }
            else
                await BindGridAsync();
        }

        private async Task BindGridAsync(bool filterMode = false)
        {
            btnFilter.Enabled = false;
            List<Customer> dataSource;
            CustomerFields fields = new CustomerFields()
            {
                FullName = true,
                Debt = true
            };

            if (!filterMode)
            {
                using (FitLabDB db = new FitLabDB())
                    dataSource = await db.Customers.GetAllAsync(fields);
            }
            else
            {
                using (FitLabDB db = new FitLabDB())
                    dataSource = await db.Customers.SearchAsync(txtSearch.Text, fields);
            }

            dgvCustomers.Rows.Clear();

            await FillGrid(dataSource);

            btnFilter.Enabled = true;
        }

        private Task FillGrid(List<Customer> customers)
        {
            return Task.Run(() =>
            {
                foreach (var data in customers)
                {
                    try
                    {
                        dgvCustomers.Invoke(new Action(() =>
                        {
                            // fill data grid view
                            dgvCustomers.Rows.Add(data.CustomerID, data.FullName, data.Debt.Separate());
                        }));
                    }
                    catch
                    {
                        return;
                    }
                }
            });
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
            _gymTime.BoxCode = txtBoxCode.Text;
            _gymTime.CustomerID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
            _gymTime.Description = txtDescription.Text;
            _gymTime.Price = (long)numPrice.Value;
            _gymTime.IsOpen = true;
            _gymTime.IsPaid = false;
            bool resualt = false;

            if (_editMode)
            {
                using (FitLabDB db = new FitLabDB())
                    resualt = db.GymTimes.Update(_gymTime);
            }
            else
            {
                _gymTime.DateAndTime = DateTime.Now;
                //for (int i = 0; i < 500; i++)
                //{
                using (FitLabDB db = new FitLabDB())
                    resualt = db.GymTimes.Insert(_gymTime);
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

        private void DgvCustomers_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                txtCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}