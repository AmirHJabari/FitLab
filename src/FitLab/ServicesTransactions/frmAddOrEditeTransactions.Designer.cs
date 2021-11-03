namespace FitLab.ServicesTransactions
{
    partial class frmAddOrEditeTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGoodses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnPaid = new System.Windows.Forms.RadioButton();
            this.rbtnNotPaid = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbService = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaidPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(336, 12);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "جستجو:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "توضیحات بیشتر:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 254);
            this.txtDescription.MaxLength = 1500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(318, 230);
            this.txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "شخص:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(12, 12);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(239, 27);
            this.txtCustomerName.TabIndex = 10;
            this.txtCustomerName.TabStop = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Debt});
            this.dgvCustomers.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvCustomers.Location = new System.Drawing.Point(336, 46);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(364, 438);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.CurrentCellChanged += new System.EventHandler(this.DgvCustomers_CurrentCellChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.FillWeight = 50F;
            this.CustomerID.HeaderText = "کد شخص";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Debt
            // 
            this.Debt.DataPropertyName = "Debt";
            this.Debt.HeaderText = "بدهی قبلی";
            this.Debt.Name = "Debt";
            this.Debt.ReadOnly = true;
            // 
            // txtGoodses
            // 
            this.txtGoodses.Location = new System.Drawing.Point(12, 115);
            this.txtGoodses.MaxLength = 1000;
            this.txtGoodses.Multiline = true;
            this.txtGoodses.Name = "txtGoodses";
            this.txtGoodses.Size = new System.Drawing.Size(318, 114);
            this.txtGoodses.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "کالاها:";
            // 
            // rbtnPaid
            // 
            this.rbtnPaid.AutoSize = true;
            this.rbtnPaid.Location = new System.Drawing.Point(336, 493);
            this.rbtnPaid.Name = "rbtnPaid";
            this.rbtnPaid.Size = new System.Drawing.Size(105, 23);
            this.rbtnPaid.TabIndex = 7;
            this.rbtnPaid.Text = "پرداخت شد";
            this.rbtnPaid.UseVisualStyleBackColor = true;
            this.rbtnPaid.CheckedChanged += new System.EventHandler(this.RbtnPaid_CheckedChanged);
            // 
            // rbtnNotPaid
            // 
            this.rbtnNotPaid.AutoSize = true;
            this.rbtnNotPaid.Checked = true;
            this.rbtnNotPaid.Location = new System.Drawing.Point(323, 522);
            this.rbtnNotPaid.Name = "rbtnNotPaid";
            this.rbtnNotPaid.Size = new System.Drawing.Size(118, 23);
            this.rbtnNotPaid.TabIndex = 7;
            this.rbtnNotPaid.TabStop = true;
            this.rbtnNotPaid.Text = "بزن به حساب";
            this.rbtnNotPaid.UseVisualStyleBackColor = true;
            this.rbtnNotPaid.CheckedChanged += new System.EventHandler(this.RbtnNotPaid_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "مبلغ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "پرداخت شده:";
            // 
            // numPrice
            // 
            this.numPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(12, 490);
            this.numPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPrice.Size = new System.Drawing.Size(175, 27);
            this.numPrice.TabIndex = 5;
            this.numPrice.ValueChanged += new System.EventHandler(this.NumPrice_ValueChanged);
            // 
            // numPaidPrice
            // 
            this.numPaidPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPaidPrice.Location = new System.Drawing.Point(12, 523);
            this.numPaidPrice.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPaidPrice.Name = "numPaidPrice";
            this.numPaidPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPaidPrice.Size = new System.Drawing.Size(175, 27);
            this.numPaidPrice.TabIndex = 6;
            this.numPaidPrice.ValueChanged += new System.EventHandler(this.NumPaidPrice_ValueChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.Location = new System.Drawing.Point(455, 495);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(245, 49);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "افزودن";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // cmbService
            // 
            this.cmbService.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbService.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "بوفه تغذیه",
            "فروش مکمل",
            " فروش لوازم ورزشی"});
            this.cmbService.Location = new System.Drawing.Point(12, 54);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(318, 26);
            this.cmbService.TabIndex = 2;
            // 
            // frmAddOrEditeTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 559);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.numPaidPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnNotPaid);
            this.Controls.Add(this.rbtnPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoodses);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAddOrEditeTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن";
            this.Load += new System.EventHandler(this.FrmAddOrEditeTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaidPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtGoodses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnPaid;
        private System.Windows.Forms.RadioButton rbtnNotPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numPaidPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.ComboBox cmbService;
    }
}