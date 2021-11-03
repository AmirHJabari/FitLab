namespace FitLab
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnGymTimes = new System.Windows.Forms.ToolStripButton();
            this.btnTransactions = new System.Windows.Forms.ToolStripButton();
            this.dgvOpenTimes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNewTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCloseTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshTimeGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTodayCash = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblThisWeekCash = new System.Windows.Forms.Label();
            this.lblThisMonthCash = new System.Windows.Forms.Label();
            this.lblThisMonthDemand = new System.Windows.Forms.Label();
            this.lblThisWeekDemand = new System.Windows.Forms.Label();
            this.lblTodayDemand = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.GymInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GymID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenTimes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnGymTimes,
            this.btnTransactions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(801, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomers.Image = global::FitLab.Properties.Resources.Users;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(59, 59);
            this.btnCustomers.Text = "مشتری ها";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.ToolTipText = "Ctrl+Shift+C";
            this.btnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // btnGymTimes
            // 
            this.btnGymTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGymTimes.Image = global::FitLab.Properties.Resources.list2;
            this.btnGymTimes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGymTimes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGymTimes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGymTimes.Name = "btnGymTimes";
            this.btnGymTimes.Size = new System.Drawing.Size(44, 59);
            this.btnGymTimes.Text = "تایم ها";
            this.btnGymTimes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGymTimes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnGymTimes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGymTimes.ToolTipText = "Ctrl+Shift+T";
            this.btnGymTimes.Click += new System.EventHandler(this.BtnGymTimes_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransactions.Image = global::FitLab.Properties.Resources._1371476499_todo_list;
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransactions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransactions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(60, 59);
            this.btnTransactions.Text = "تراکنش ها";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactions.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransactions.ToolTipText = "Ctrl+T";
            this.btnTransactions.Click += new System.EventHandler(this.BtnTransactions_Click);
            // 
            // dgvOpenTimes
            // 
            this.dgvOpenTimes.AllowUserToAddRows = false;
            this.dgvOpenTimes.AllowUserToDeleteRows = false;
            this.dgvOpenTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenTimes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvOpenTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GymID,
            this.CustomerName,
            this.DateAndTime,
            this.BoxCode,
            this.Price,
            this.Description});
            this.dgvOpenTimes.Location = new System.Drawing.Point(7, 24);
            this.dgvOpenTimes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOpenTimes.Name = "dgvOpenTimes";
            this.dgvOpenTimes.ReadOnly = true;
            this.dgvOpenTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpenTimes.Size = new System.Drawing.Size(762, 315);
            this.dgvOpenTimes.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.dgvOpenTimes);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(14, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(775, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تایم های باز";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewTime,
            this.toolStripSeparator1,
            this.btnCloseTime,
            this.toolStripSeparator3,
            this.btnEditTime,
            this.toolStripSeparator2,
            this.btnDeleteTime,
            this.toolStripSeparator4,
            this.btnRefreshTimeGrid,
            this.toolStripSeparator5});
            this.toolStrip2.Location = new System.Drawing.Point(3, 343);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(769, 47);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnNewTime
            // 
            this.btnNewTime.Image = global::FitLab.Properties.Resources._1371475930_filenew;
            this.btnNewTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTime.Name = "btnNewTime";
            this.btnNewTime.Size = new System.Drawing.Size(95, 44);
            this.btnNewTime.Text = "تایم جدید";
            this.btnNewTime.ToolTipText = "Ctrl+A";
            this.btnNewTime.Click += new System.EventHandler(this.BtnNewTime_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnCloseTime
            // 
            this.btnCloseTime.Image = global::FitLab.Properties.Resources.don;
            this.btnCloseTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCloseTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseTime.Name = "btnCloseTime";
            this.btnCloseTime.Size = new System.Drawing.Size(98, 44);
            this.btnCloseTime.Text = "بستن تایم";
            this.btnCloseTime.ToolTipText = "Ctrl+C";
            this.btnCloseTime.Click += new System.EventHandler(this.BtnCloseTime_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // btnEditTime
            // 
            this.btnEditTime.Image = global::FitLab.Properties.Resources._1371475973_document_edit;
            this.btnEditTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTime.Name = "btnEditTime";
            this.btnEditTime.Size = new System.Drawing.Size(108, 44);
            this.btnEditTime.Text = "ویرایش تایم";
            this.btnEditTime.ToolTipText = "Ctrl+E";
            this.btnEditTime.Click += new System.EventHandler(this.BtnEditTime_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnDeleteTime
            // 
            this.btnDeleteTime.Image = global::FitLab.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTime.Name = "btnDeleteTime";
            this.btnDeleteTime.Size = new System.Drawing.Size(97, 44);
            this.btnDeleteTime.Text = "حذف تایم";
            this.btnDeleteTime.ToolTipText = "Ctrl+D";
            this.btnDeleteTime.Click += new System.EventHandler(this.BtnDeleteTime_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // btnRefreshTimeGrid
            // 
            this.btnRefreshTimeGrid.Image = global::FitLab.Properties.Resources._1371476342_Refresh;
            this.btnRefreshTimeGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshTimeGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshTimeGrid.Name = "btnRefreshTimeGrid";
            this.btnRefreshTimeGrid.Size = new System.Drawing.Size(104, 44);
            this.btnRefreshTimeGrid.Text = "بروز رسانی";
            this.btnRefreshTimeGrid.ToolTipText = "Ctrl+R";
            this.btnRefreshTimeGrid.Click += new System.EventHandler(this.BtnRefreshTimeGrid_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "امروز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "این هفته";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "این ماه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "دوره:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "نقد:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "طلب:";
            // 
            // lblTodayCash
            // 
            this.lblTodayCash.Location = new System.Drawing.Point(520, 132);
            this.lblTodayCash.Name = "lblTodayCash";
            this.lblTodayCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTodayCash.Size = new System.Drawing.Size(221, 16);
            this.lblTodayCash.TabIndex = 9;
            this.lblTodayCash.Text = "0";
            this.lblTodayCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(513, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 126);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(257, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 126);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(743, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 126);
            this.panel3.TabIndex = 11;
            // 
            // lblThisWeekCash
            // 
            this.lblThisWeekCash.Location = new System.Drawing.Point(264, 132);
            this.lblThisWeekCash.Name = "lblThisWeekCash";
            this.lblThisWeekCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisWeekCash.Size = new System.Drawing.Size(243, 16);
            this.lblThisWeekCash.TabIndex = 13;
            this.lblThisWeekCash.Text = "0";
            this.lblThisWeekCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThisMonthCash
            // 
            this.lblThisMonthCash.Location = new System.Drawing.Point(12, 132);
            this.lblThisMonthCash.Name = "lblThisMonthCash";
            this.lblThisMonthCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMonthCash.Size = new System.Drawing.Size(239, 16);
            this.lblThisMonthCash.TabIndex = 14;
            this.lblThisMonthCash.Text = "0";
            this.lblThisMonthCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThisMonthDemand
            // 
            this.lblThisMonthDemand.Location = new System.Drawing.Point(12, 177);
            this.lblThisMonthDemand.Name = "lblThisMonthDemand";
            this.lblThisMonthDemand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMonthDemand.Size = new System.Drawing.Size(239, 16);
            this.lblThisMonthDemand.TabIndex = 17;
            this.lblThisMonthDemand.Text = "0";
            this.lblThisMonthDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThisWeekDemand
            // 
            this.lblThisWeekDemand.Location = new System.Drawing.Point(264, 177);
            this.lblThisWeekDemand.Name = "lblThisWeekDemand";
            this.lblThisWeekDemand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisWeekDemand.Size = new System.Drawing.Size(243, 16);
            this.lblThisWeekDemand.TabIndex = 16;
            this.lblThisWeekDemand.Text = "0";
            this.lblThisWeekDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayDemand
            // 
            this.lblTodayDemand.Location = new System.Drawing.Point(520, 177);
            this.lblTodayDemand.Name = "lblTodayDemand";
            this.lblTodayDemand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTodayDemand.Size = new System.Drawing.Size(221, 16);
            this.lblTodayDemand.TabIndex = 15;
            this.lblTodayDemand.Text = "0";
            this.lblTodayDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GymInfoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 20);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // GymInfoToolStripMenuItem
            // 
            this.GymInfoToolStripMenuItem.Name = "GymInfoToolStripMenuItem";
            this.GymInfoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.GymInfoToolStripMenuItem.Text = "اطلاعات باشگاه";
            this.GymInfoToolStripMenuItem.Click += new System.EventHandler(this.GymInfoToolStripMenuItem_Click);
            // 
            // GymID
            // 
            this.GymID.DataPropertyName = "ID";
            this.GymID.HeaderText = "کد تایم";
            this.GymID.Name = "GymID";
            this.GymID.ReadOnly = true;
            this.GymID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "شخص";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // DateAndTime
            // 
            this.DateAndTime.DataPropertyName = "TimeOfDay";
            this.DateAndTime.HeaderText = "شروع در";
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            // 
            // BoxCode
            // 
            this.BoxCode.DataPropertyName = "BoxCode";
            this.BoxCode.HeaderText = "کد صندوق";
            this.BoxCode.Name = "BoxCode";
            this.BoxCode.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "مبلغ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 627);
            this.Controls.Add(this.lblThisMonthDemand);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblThisWeekDemand);
            this.Controls.Add(this.lblTodayDemand);
            this.Controls.Add(this.lblThisMonthCash);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblThisWeekCash);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTodayCash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitLab";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenTimes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btnCustomers;
        public System.Windows.Forms.ToolStripButton btnGymTimes;
        public System.Windows.Forms.ToolStripButton btnTransactions;
        private System.Windows.Forms.DataGridView dgvOpenTimes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTodayCash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblThisWeekCash;
        private System.Windows.Forms.Label lblThisMonthCash;
        private System.Windows.Forms.Label lblThisMonthDemand;
        private System.Windows.Forms.Label lblThisWeekDemand;
        private System.Windows.Forms.Label lblTodayDemand;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnNewTime;
        private System.Windows.Forms.ToolStripButton btnCloseTime;
        private System.Windows.Forms.ToolStripButton btnEditTime;
        private System.Windows.Forms.ToolStripButton btnDeleteTime;
        private System.Windows.Forms.ToolStripButton btnRefreshTimeGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem GymInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GymID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}