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
using ValidationComponents;

namespace FitLab.Settings
{
    public partial class frmGymRulesAndProperties : Form
    {
        public frmGymRulesAndProperties()
        {
            InitializeComponent();
            txtGymName.Text = StaticTables.GymRulesAndProperties.GymName;
            txtOwnerName.Text = StaticTables.GymRulesAndProperties.OwnerName;
            numDefaultPriceForTimes.Value = StaticTables.GymRulesAndProperties.DefaultPriceForGymTime;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                try
                {
                    GymRulesAndProperties rulesAndProperties = new GymRulesAndProperties()
                    {
                        GymName = txtGymName.Text,
                        OwnerName = txtOwnerName.Text,
                        DefaultPriceForGymTime = (long)numDefaultPriceForTimes.Value
                    };
                    StaticTables.UpdateGymRulesAndProperties(rulesAndProperties);
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    DialogResult = DialogResult.No;
                }
            }
            else if (string.IsNullOrEmpty(txtGymName.Text))
                txtGymName.Focus();
            else if (string.IsNullOrEmpty(txtOwnerName.Text))
                txtOwnerName.Focus();
        }
    }
}
