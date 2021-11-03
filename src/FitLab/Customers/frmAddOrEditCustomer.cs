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
using FitLab.DataLayer;

using FitLab.DataLayer.Models;
using ValidationComponents;

namespace FitLab.Customers
{
    public partial class frmAddOrEditCustomer : Form
    {
        private Customer _customer;
        private bool _editMode = false;
        public frmAddOrEditCustomer(bool editMode = false, int customerID = -1)
        {
            InitializeComponent();
            if (editMode && customerID != -1)
            {
                _editMode = true;
                using (FitLabDB db = new FitLabDB())
                    _customer = db.Customers.GetByID(customerID);

                this.Text = "ویرایش شخص";
                btnSubmit.Text = "ویرایش";
                string signDate = (_customer.BirthDate == null) ? "" : _customer.BirthDate.ToShamsi();
                txtBirthDate.Text = signDate;
                txtEmail.Text = _customer.Email;
                txtMoreInfo.Text = _customer.MoreInfo;
                txtName.Text = _customer.FullName;
                txtPhoneNumber.Text = _customer.PhoneNumber;
                txtSignDate.Text = (_customer.SignDate == null) ? DateTime.Now.ToShamsi() : _customer.SignDate.ToShamsi();
            }
            else if (!editMode && customerID == -1)
            {
                _customer = new Customer();
                txtSignDate.Text = DateTime.Now.ToShamsi();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                bool resualt;

                _customer.Email = txtEmail.Text;
                _customer.FullName = txtName.Text;
                _customer.MoreInfo = txtMoreInfo.Text;
                _customer.PhoneNumber = txtPhoneNumber.Text;



                if (!txtBirthDate.Text.Equals("    -  -"))
                {
                    try
                    {
                        _customer.BirthDate = MyConverter.ToGregorianDate(txtBirthDate.Text);
                    }
                    catch
                    {
                        MessageBox.Show("لطفا یک تاریخ صحیح و معتبر را برای تاریخ تولد وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBirthDate.Focus();
                        return;
                    }
                }

                if (!txtSignDate.Text.Equals("    -  -"))
                {
                    try
                    {
                        _customer.SignDate = MyConverter.ToGregorianDate(txtSignDate.Text);
                    }
                    catch
                    {
                        MessageBox.Show("لطفا یک تاریخ صحیح و معتبر را برای تاریخ عضویت وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSignDate.Focus();
                        return;
                    }
                }


                if (_editMode)
                {
                    using (FitLabDB db = new FitLabDB())
                        resualt = db.Customers.Update(_customer);
                }
                else
                {
                    //for (int i = 0; i < 1000; i++)
                    //{
                        using (FitLabDB db = new FitLabDB())
                            resualt = db.Customers.Insert(_customer);
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
            else
            {
                txtName.Focus();
            }
        }

        private void MaskedSetCursorPosition(MaskedTextBox txtbox)
        {
            if (txtbox.Text == "    -  -")
            {
                txtbox.SelectionLength = 0;
                txtbox.SelectionStart = 0;
            }
        }

        private void TxtBirthDate_MouseUp(object sender, MouseEventArgs e)
        {
            MaskedSetCursorPosition((MaskedTextBox)sender);
        }

        private void TxtBirthDate_Enter(object sender, EventArgs e)
        {
            MaskedSetCursorPosition((MaskedTextBox)sender);
        }
    }
}
