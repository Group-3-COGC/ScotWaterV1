namespace ScotWaterV1.Forms
{
    partial class DisplayBill
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayBill));
            this.btnBillSearch = new System.Windows.Forms.Button();
            this.txtBillSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.pnlFinal = new System.Windows.Forms.Panel();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlTax = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.pnlCharges = new System.Windows.Forms.Panel();
            this.dgvBillBreakdown = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlFinal.SuspendLayout();
            this.pnlTax.SuspendLayout();
            this.pnlCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakdown)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBillSearch
            // 
            this.btnBillSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBillSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillSearch.FlatAppearance.BorderSize = 0;
            this.btnBillSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBillSearch.ForeColor = System.Drawing.Color.White;
            this.btnBillSearch.Location = new System.Drawing.Point(386, 205);
            this.btnBillSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillSearch.Name = "btnBillSearch";
            this.btnBillSearch.Size = new System.Drawing.Size(118, 34);
            this.btnBillSearch.TabIndex = 26;
            this.btnBillSearch.Text = "Search";
            this.btnBillSearch.UseVisualStyleBackColor = false;
            this.btnBillSearch.Click += new System.EventHandler(this.btnBillSearch_Click);
            // 
            // txtBillSearch
            // 
            this.txtBillSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBillSearch.Location = new System.Drawing.Point(160, 205);
            this.txtBillSearch.Multiline = true;
            this.txtBillSearch.Name = "txtBillSearch";
            this.txtBillSearch.Size = new System.Drawing.Size(199, 34);
            this.txtBillSearch.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(11, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search Bill ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Final Cost";
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.AutoSize = true;
            this.lblFinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinalCost.Location = new System.Drawing.Point(127, 20);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(20, 25);
            this.lblFinalCost.TabIndex = 0;
            this.lblFinalCost.Text = "-";
            // 
            // pnlFinal
            // 
            this.pnlFinal.BackColor = System.Drawing.Color.LightCoral;
            this.pnlFinal.Controls.Add(this.lblFinalCost);
            this.pnlFinal.Controls.Add(this.label7);
            this.pnlFinal.Location = new System.Drawing.Point(840, 246);
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(293, 154);
            this.pnlFinal.TabIndex = 4;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVAT.Location = new System.Drawing.Point(184, 44);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(20, 25);
            this.lblVAT.TabIndex = 5;
            this.lblVAT.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "VAT";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.Location = new System.Drawing.Point(184, 76);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(20, 25);
            this.lblSubTotal.TabIndex = 2;
            this.lblSubTotal.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subtotal";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(184, 10);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(20, 25);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "-";
            // 
            // pnlTax
            // 
            this.pnlTax.BackColor = System.Drawing.Color.LightGreen;
            this.pnlTax.Controls.Add(this.lblDiscount);
            this.pnlTax.Controls.Add(this.label5);
            this.pnlTax.Controls.Add(this.lblSubTotal);
            this.pnlTax.Controls.Add(this.label6);
            this.pnlTax.Controls.Add(this.label4);
            this.pnlTax.Controls.Add(this.lblVAT);
            this.pnlTax.Location = new System.Drawing.Point(475, 246);
            this.pnlTax.Name = "pnlTax";
            this.pnlTax.Size = new System.Drawing.Size(331, 154);
            this.pnlTax.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Charges";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCharges.Location = new System.Drawing.Point(238, 76);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(20, 25);
            this.lblTotalCharges.TabIndex = 4;
            this.lblTotalCharges.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Date";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.Location = new System.Drawing.Point(238, 10);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(20, 25);
            this.lblBusinessName.TabIndex = 1;
            this.lblBusinessName.Text = "-";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillDate.Location = new System.Drawing.Point(238, 44);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(20, 25);
            this.lblBillDate.TabIndex = 0;
            this.lblBillDate.Text = "-";
            // 
            // pnlCharges
            // 
            this.pnlCharges.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCharges.Controls.Add(this.lblBillDate);
            this.pnlCharges.Controls.Add(this.lblBusinessName);
            this.pnlCharges.Controls.Add(this.label2);
            this.pnlCharges.Controls.Add(this.label1);
            this.pnlCharges.Controls.Add(this.lblTotalCharges);
            this.pnlCharges.Controls.Add(this.label3);
            this.pnlCharges.Location = new System.Drawing.Point(28, 246);
            this.pnlCharges.Name = "pnlCharges";
            this.pnlCharges.Size = new System.Drawing.Size(415, 154);
            this.pnlCharges.TabIndex = 2;
            // 
            // dgvBillBreakdown
            // 
            this.dgvBillBreakdown.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvBillBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillBreakdown.Location = new System.Drawing.Point(338, 450);
            this.dgvBillBreakdown.Name = "dgvBillBreakdown";
            this.dgvBillBreakdown.RowHeadersWidth = 51;
            this.dgvBillBreakdown.Size = new System.Drawing.Size(497, 203);
            this.dgvBillBreakdown.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1432, 155);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(212, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Display Bill ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // DisplayBill
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 687);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvBillBreakdown);
            this.Controls.Add(this.pnlCharges);
            this.Controls.Add(this.pnlTax);
            this.Controls.Add(this.pnlFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBillSearch);
            this.Controls.Add(this.btnBillSearch);
            this.Name = "DisplayBill";
            this.Load += new System.EventHandler(this.DisplayBill_Load);
            this.pnlFinal.ResumeLayout(false);
            this.pnlFinal.PerformLayout();
            this.pnlTax.ResumeLayout(false);
            this.pnlTax.PerformLayout();
            this.pnlCharges.ResumeLayout(false);
            this.pnlCharges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakdown)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillSearch;
        private System.Windows.Forms.TextBox txtBillSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFinalCost;
        private System.Windows.Forms.Panel pnlFinal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnlTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Panel pnlCharges;
        private System.Windows.Forms.DataGridView dgvBillBreakdown;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
    }
}