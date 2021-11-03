namespace FitLab.GymTimes
{
    partial class frmPayGymTime
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.numPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.lblRemainigPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnNotPaid = new System.Windows.Forms.RadioButton();
            this.lblProp = new System.Windows.Forms.Label();
            this.rbtnPaid = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numPaidPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPay.Location = new System.Drawing.Point(227, 174);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(206, 49);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "تسویه";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(12, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 49);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRemaining.Location = new System.Drawing.Point(12, 129);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRemaining.Size = new System.Drawing.Size(421, 31);
            this.lblRemaining.TabIndex = 18;
            this.lblRemaining.Text = "1,000 تومان بزن به حساب";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPaidPrice
            // 
            this.numPaidPrice.Enabled = false;
            this.numPaidPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPaidPrice.Location = new System.Drawing.Point(12, 84);
            this.numPaidPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPaidPrice.Name = "numPaidPrice";
            this.numPaidPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPaidPrice.Size = new System.Drawing.Size(178, 27);
            this.numPaidPrice.TabIndex = 17;
            this.numPaidPrice.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPaidPrice.ValueChanged += new System.EventHandler(this.NumPaidPrice_ValueChanged);
            // 
            // lblRemainigPrice
            // 
            this.lblRemainigPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRemainigPrice.Location = new System.Drawing.Point(13, 58);
            this.lblRemainigPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainigPrice.Name = "lblRemainigPrice";
            this.lblRemainigPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRemainigPrice.Size = new System.Drawing.Size(177, 18);
            this.lblRemainigPrice.TabIndex = 16;
            this.lblRemainigPrice.Text = "5,000";
            this.lblRemainigPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "تسویه شده:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "بدهی مانده:";
            // 
            // rbtnNotPaid
            // 
            this.rbtnNotPaid.AutoSize = true;
            this.rbtnNotPaid.Location = new System.Drawing.Point(314, 88);
            this.rbtnNotPaid.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNotPaid.Name = "rbtnNotPaid";
            this.rbtnNotPaid.Size = new System.Drawing.Size(118, 23);
            this.rbtnNotPaid.TabIndex = 13;
            this.rbtnNotPaid.TabStop = true;
            this.rbtnNotPaid.Text = "بزن به حساب";
            this.rbtnNotPaid.UseVisualStyleBackColor = true;
            this.rbtnNotPaid.CheckedChanged += new System.EventHandler(this.RbtnNotPaid_CheckedChanged);
            // 
            // lblProp
            // 
            this.lblProp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProp.Location = new System.Drawing.Point(12, 9);
            this.lblProp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp.Name = "lblProp";
            this.lblProp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProp.Size = new System.Drawing.Size(421, 35);
            this.lblProp.TabIndex = 21;
            this.lblProp.Text = "تسویه تایم ";
            this.lblProp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnPaid
            // 
            this.rbtnPaid.AutoSize = true;
            this.rbtnPaid.Location = new System.Drawing.Point(334, 58);
            this.rbtnPaid.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPaid.Name = "rbtnPaid";
            this.rbtnPaid.Size = new System.Drawing.Size(98, 23);
            this.rbtnPaid.TabIndex = 12;
            this.rbtnPaid.TabStop = true;
            this.rbtnPaid.Text = "تسویه شد";
            this.rbtnPaid.UseVisualStyleBackColor = true;
            this.rbtnPaid.CheckedChanged += new System.EventHandler(this.RbtnPaid_CheckedChanged);
            // 
            // frmPayGymTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 235);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.numPaidPrice);
            this.Controls.Add(this.lblRemainigPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnNotPaid);
            this.Controls.Add(this.rbtnPaid);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPayGymTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسویه تایم";
            ((System.ComponentModel.ISupportInitialize)(this.numPaidPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.NumericUpDown numPaidPrice;
        private System.Windows.Forms.Label lblRemainigPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnNotPaid;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.RadioButton rbtnPaid;
    }
}