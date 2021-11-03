using FitLab.DataLayer;
using FitLab.DataLayer.Models;
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
    public partial class frmPayGymTime : Form
    {
        private GymTime _gymTime;
        private readonly long _remainigPrice;
        public frmPayGymTime(string customerName, int timeID)
        {
            InitializeComponent();
            using (FitLabDB db = new FitLabDB())
                _gymTime = db.GymTimes.GetByID(timeID);

            _remainigPrice = _gymTime.Price - _gymTime.PaidPrice;
            numPaidPrice.Maximum = _remainigPrice;
            rbtnPaid.Checked = true;
            lblProp.Text += customerName + ".";
            lblRemainigPrice.Text = _remainigPrice.Separate();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NumPaidPrice_ValueChanged(object sender, EventArgs e)
        {
            string remaining = (_remainigPrice - ((long)numPaidPrice.Value)).Separate();
            lblRemaining.Text = $"{remaining} تومان بزن به حساب.";
            if (_gymTime.Price <= ((long)numPaidPrice.Value))
            {
                rbtnPaid.Checked = true;
            }
        }

        private void RbtnNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            numPaidPrice.Enabled = true;
            numPaidPrice.Value = _remainigPrice / 2;
        }

        private void RbtnPaid_CheckedChanged(object sender, EventArgs e)
        {
            numPaidPrice.Enabled = false;
            numPaidPrice.Value = _remainigPrice;
            lblRemaining.Text = $"{0} تومان بزن به حساب.";
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (numPaidPrice.Value <= 0)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            _gymTime.PaidPrice = (rbtnPaid.Checked) ? _gymTime.Price : _gymTime.PaidPrice + (long)numPaidPrice.Value;
            _gymTime.IsPaid = rbtnPaid.Checked;


            bool resualt;

            using (FitLabDB db = new FitLabDB())
                resualt = db.GymTimes.Update(_gymTime);

            if (resualt)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
