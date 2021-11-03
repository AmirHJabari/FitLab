namespace FitLab.GymTimes
{
    partial class frmGymTimes
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCloseTimes = new System.Windows.Forms.DataGridView();
            this.TimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPay = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbIsPaid = new System.Windows.Forms.ComboBox();
            this.txtDateTo = new System.Windows.Forms.MaskedTextBox();
            this.txtDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpSearch = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloseTimes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCloseTimes);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 474);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست تایم های بسته: ";
            this.ttpSearch.SetToolTip(this.groupBox1, "Ctrl+L");
            // 
            // dgvCloseTimes
            // 
            this.dgvCloseTimes.AllowUserToAddRows = false;
            this.dgvCloseTimes.AllowUserToDeleteRows = false;
            this.dgvCloseTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCloseTimes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCloseTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCloseTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeID,
            this.CustomerID,
            this.CustomerName,
            this.Date,
            this.Length,
            this.BoxCode,
            this.Price,
            this.IsPaid,
            this.Debt});
            this.dgvCloseTimes.Location = new System.Drawing.Point(6, 22);
            this.dgvCloseTimes.Name = "dgvCloseTimes";
            this.dgvCloseTimes.ReadOnly = true;
            this.dgvCloseTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCloseTimes.Size = new System.Drawing.Size(844, 446);
            this.dgvCloseTimes.TabIndex = 0;
            // 
            // TimeID
            // 
            this.TimeID.HeaderText = "کد تایم";
            this.TimeID.Name = "TimeID";
            this.TimeID.ReadOnly = true;
            this.TimeID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "کد شخص";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "FullName";
            this.CustomerName.HeaderText = "نام شخص";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 70F;
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.FillWeight = 70F;
            this.Length.HeaderText = "مدت";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // BoxCode
            // 
            this.BoxCode.FillWeight = 50F;
            this.BoxCode.HeaderText = "کد صندوق";
            this.BoxCode.Name = "BoxCode";
            this.BoxCode.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "مبلغ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // IsPaid
            // 
            this.IsPaid.FillWeight = 40F;
            this.IsPaid.HeaderText = "تسویه شده";
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            // 
            // Debt
            // 
            this.Debt.HeaderText = "بدهی مانده";
            this.Debt.Name = "Debt";
            this.Debt.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInfo,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.toolStripSeparator2,
            this.btnPay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(880, 62);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::FitLab.Properties.Resources._1371475973_document_edit;
            this.btnInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(58, 59);
            this.btnInfo.Text = "توضیحات";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.ToolTipText = "Ctrl+I";
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::FitLab.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 59);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ToolTipText = "Ctrl+D";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::FitLab.Properties.Resources._1371476342_Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 59);
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.ToolTipText = "Ctrl+R";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // btnPay
            // 
            this.btnPay.Image = global::FitLab.Properties.Resources.servicesCosts;
            this.btnPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(44, 59);
            this.btnPay.Text = "تسویه";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPay.ToolTipText = "Ctrl+X";
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.cmbIsPaid);
            this.groupBox2.Controls.Add(this.txtDateTo);
            this.groupBox2.Controls.Add(this.txtDateFrom);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فیلتر: ";
            this.ttpSearch.SetToolTip(this.groupBox2, "Ctrl+S");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(408, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "تا تاریخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(564, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "از تاریخ:";
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFilter.Location = new System.Drawing.Point(6, 21);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(144, 48);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "جستجو";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // cmbIsPaid
            // 
            this.cmbIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbIsPaid.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbIsPaid.FormattingEnabled = true;
            this.cmbIsPaid.Items.AddRange(new object[] {
            "همه",
            "تسویه شده",
            "تسویه نشده"});
            this.cmbIsPaid.Location = new System.Drawing.Point(156, 31);
            this.cmbIsPaid.Name = "cmbIsPaid";
            this.cmbIsPaid.Size = new System.Drawing.Size(150, 26);
            this.cmbIsPaid.TabIndex = 4;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDateTo.Location = new System.Drawing.Point(312, 31);
            this.txtDateTo.Mask = "0000-00-00";
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateTo.Size = new System.Drawing.Size(90, 25);
            this.txtDateTo.TabIndex = 3;
            this.txtDateTo.Enter += new System.EventHandler(this.TxtDateTo_Enter);
            this.txtDateTo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtDateTo_MouseUp);
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDateFrom.Location = new System.Drawing.Point(468, 31);
            this.txtDateFrom.Mask = "0000-00-00";
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateFrom.Size = new System.Drawing.Size(90, 25);
            this.txtDateFrom.TabIndex = 2;
            this.txtDateFrom.Enter += new System.EventHandler(this.TxtDateTo_Enter);
            this.txtDateFrom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtDateTo_MouseUp);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(625, 31);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 25);
            this.txtSearch.TabIndex = 1;
            this.ttpSearch.SetToolTip(this.txtSearch, "نام و کد شخص");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(802, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "عبارت:";
            // 
            // ttpSearch
            // 
            this.ttpSearch.AutomaticDelay = 0;
            this.ttpSearch.IsBalloon = true;
            this.ttpSearch.StripAmpersands = true;
            // 
            // frmGymTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGymTimes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تایم ها";
            this.Load += new System.EventHandler(this.FrmGymTimes_LoadAsync);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloseTimes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCloseTimes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnPay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDateTo;
        private System.Windows.Forms.MaskedTextBox txtDateFrom;
        private System.Windows.Forms.ComboBox cmbIsPaid;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttpSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
    }
}