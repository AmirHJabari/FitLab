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
    public partial class frmShowDescription : Form
    {
        private GymTime _gymTime;
        public frmShowDescription(int timeID)
        {
            InitializeComponent();
            using (FitLabDB db = new FitLabDB())
            {
                _gymTime = db.GymTimes.GetByID(timeID);
                this.Text +=":  " + db.Customers.GetNameByID(_gymTime.CustomerID);
            }

            txtDescription.Text = _gymTime.Description;
            txtDescription.SelectionStart = txtDescription.Text.Length;
            txtDescription.SelectionLength = 0;

            lblDate.Text = _gymTime.DateAndTime.ToShamsi() + " " + _gymTime.DateAndTime.TimeOfDay.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _gymTime.Description = txtDescription.Text;
            bool resualt;

            using (FitLabDB db = new FitLabDB())
            {
                resualt = db.GymTimes.Update(_gymTime);
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
    }
}
