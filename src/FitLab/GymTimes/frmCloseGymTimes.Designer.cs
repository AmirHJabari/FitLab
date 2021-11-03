namespace FitLab.GymTimes
{
    partial class frmCloseGymTimes
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
            this.lblProp = new System.Windows.Forms.Label();
            this.rbtnPaid = new System.Windows.Forms.RadioButton();
            this.rbtnNotPaid = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCloseTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPaidPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProp
            // 
            this.lblProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblProp.Location = new System.Drawing.Point(13, 9);
            this.lblProp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(396, 25);
            this.lblProp.TabIndex = 1;
            this.lblProp.Text = "امیر جباری 02:14:29 طولش داد.";
            this.lblProp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnPaid
            // 
            this.rbtnPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnPaid.AutoSize = true;
            this.rbtnPaid.Location = new System.Drawing.Point(310, 62);
            this.rbtnPaid.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPaid.Name = "rbtnPaid";
            this.rbtnPaid.Size = new System.Drawing.Size(99, 22);
            this.rbtnPaid.TabIndex = 2;
            this.rbtnPaid.TabStop = true;
            this.rbtnPaid.Text = "پرداخت شد";
            this.rbtnPaid.UseVisualStyleBackColor = true;
            this.rbtnPaid.CheckedChanged += new System.EventHandler(this.RbtnPaid_CheckedChanged);
            // 
            // rbtnNotPaid
            // 
            this.rbtnNotPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnNotPaid.AutoSize = true;
            this.rbtnNotPaid.Location = new System.Drawing.Point(298, 92);
            this.rbtnNotPaid.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNotPaid.Name = "rbtnNotPaid";
            this.rbtnNotPaid.Size = new System.Drawing.Size(111, 22);
            this.rbtnNotPaid.TabIndex = 3;
            this.rbtnNotPaid.TabStop = true;
            this.rbtnNotPaid.Text = "بزن به حساب";
            this.rbtnNotPaid.UseVisualStyleBackColor = true;
            this.rbtnNotPaid.CheckedChanged += new System.EventHandler(this.RbtnNotPaid_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "مبلغ:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "پرداخت شده:";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Location = new System.Drawing.Point(13, 66);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(168, 18);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "5,000";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPaidPrice
            // 
            this.numPaidPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPaidPrice.Enabled = false;
            this.numPaidPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPaidPrice.Location = new System.Drawing.Point(12, 92);
            this.numPaidPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPaidPrice.Name = "numPaidPrice";
            this.numPaidPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPaidPrice.Size = new System.Drawing.Size(169, 25);
            this.numPaidPrice.TabIndex = 8;
            this.numPaidPrice.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPaidPrice.ValueChanged += new System.EventHandler(this.NumPaidPrice_ValueChanged);
            // 
            // lblRemaining
            // 
            this.lblRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemaining.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRemaining.Location = new System.Drawing.Point(12, 137);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRemaining.Size = new System.Drawing.Size(398, 31);
            this.lblRemaining.TabIndex = 9;
            this.lblRemaining.Text = "1,000 تومان بزن به حساب";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(16, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCloseTime
            // 
            this.btnCloseTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTime.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCloseTime.Location = new System.Drawing.Point(230, 171);
            this.btnCloseTime.Name = "btnCloseTime";
            this.btnCloseTime.Size = new System.Drawing.Size(180, 49);
            this.btnCloseTime.TabIndex = 11;
            this.btnCloseTime.Text = "بستن";
            this.btnCloseTime.UseVisualStyleBackColor = true;
            this.btnCloseTime.Click += new System.EventHandler(this.BtnCloseTime_Click);
            // 
            // frmCloseGymTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 232);
            this.Controls.Add(this.btnCloseTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.numPaidPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnNotPaid);
            this.Controls.Add(this.rbtnPaid);
            this.Controls.Add(this.lblProp);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCloseGymTimes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بستن تایم";
            ((System.ComponentModel.ISupportInitialize)(this.numPaidPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.RadioButton rbtnPaid;
        private System.Windows.Forms.RadioButton rbtnNotPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPaidPrice;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseTime;
    }
}