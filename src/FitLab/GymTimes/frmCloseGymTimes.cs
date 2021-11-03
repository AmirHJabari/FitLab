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

namespace FitLab.GymTimes
{
    public partial class frmCloseGymTimes : Form
    {
        private GymTime _gymTime;
        private TimeSpan _length;
        public frmCloseGymTimes(string customerName, int timeID)
        {
            InitializeComponent();
            using (FitLabDB db = new FitLabDB())
                _gymTime = db.GymTimes.GetByID(timeID);

            _length = DateTime.Now.TimeOfDay - _gymTime.DateAndTime.TimeOfDay;
            numPaidPrice.Maximum = _gymTime.Price;
            string str = _length.ToString(@"hh\:mm\:ss");
            lblProp.Text = $"{customerName} {str} طولش داد.";
            rbtnPaid.Checked = true;
            lblPrice.Text = _gymTime.Price.Separate();
        }

        private void RbtnPaid_CheckedChanged(object sender, EventArgs e)
        {
            numPaidPrice.Enabled = false;
            numPaidPrice.Value = _gymTime.Price;
            lblRemaining.Text = $"{0} تومان بزن به حساب.";
        }

        private void RbtnNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            numPaidPrice.Enabled = true;
            numPaidPrice.Value = 0;
        }

        private void NumPaidPrice_ValueChanged(object sender, EventArgs e)
        {
            string remaining = (_gymTime.Price - ((long)numPaidPrice.Value)).Separate();
            lblRemaining.Text = $"{remaining} تومان بزن به حساب.";
            if (_gymTime.Price <= ((long)numPaidPrice.Value))
            {
                rbtnPaid.Checked = true;
            }
        }

        private void BtnCloseTime_Click(object sender, EventArgs e)
        {
            _gymTime.IsOpen = false;
            _gymTime.Length = Convert.ToDateTime(_length.ToString(@"hh\:mm\:ss"));
            _gymTime.PaidPrice = (rbtnPaid.Checked) ? _gymTime.Price : (long)numPaidPrice.Value;
            _gymTime.IsPaid = rbtnPaid.Checked;

            bool resualt;

            using (FitLabDB db = new FitLabDB())
            {
                resualt = db.GymTimes.Update(_gymTime);
                if (resualt)
                {
                    long remaining = _gymTime.Price - _gymTime.PaidPrice;
                }
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
