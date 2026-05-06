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
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnBillSearch = new System.Windows.Forms.Button();
            this.txtBillSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlFinal = new System.Windows.Forms.Panel();
            this.pnlTax = new System.Windows.Forms.Panel();
            this.pnlCharges = new System.Windows.Forms.Panel();
            this.dgvBillBreakdown = new System.Windows.Forms.DataGridView();
            this.pnlFinal.SuspendLayout();
            this.pnlTax.SuspendLayout();
            this.pnlCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakdown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.Location = new System.Drawing.Point(221, 12);
            this.lblBusinessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(20, 25);
            this.lblBusinessName.TabIndex = 1;
            this.lblBusinessName.Text = "-";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillDate.Location = new System.Drawing.Point(221, 54);
            this.lblBillDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(20, 25);
            this.lblBillDate.TabIndex = 2;
            this.lblBillDate.Text = "-";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCharges.Location = new System.Drawing.Point(221, 94);
            this.lblTotalCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(20, 25);
            this.lblTotalCharges.TabIndex = 3;
            this.lblTotalCharges.Text = "-";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(246, 12);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(20, 25);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "-";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.Location = new System.Drawing.Point(246, 94);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(20, 25);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "-";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVAT.Location = new System.Drawing.Point(246, 54);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(20, 25);
            this.lblVAT.TabIndex = 6;
            this.lblVAT.Text = "-";
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.AutoSize = true;
            this.lblFinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinalCost.Location = new System.Drawing.Point(160, 25);
            this.lblFinalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(20, 25);
            this.lblFinalCost.TabIndex = 7;
            this.lblFinalCost.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bill Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Charges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(4, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(4, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Final Cost";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.White;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMainMenu.Location = new System.Drawing.Point(603, 679);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(133, 43);
            this.btnMainMenu.TabIndex = 24;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnBillSearch
            // 
            this.btnBillSearch.BackColor = System.Drawing.Color.White;
            this.btnBillSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBillSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBillSearch.Location = new System.Drawing.Point(520, 31);
            this.btnBillSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBillSearch.Name = "btnBillSearch";
            this.btnBillSearch.Size = new System.Drawing.Size(158, 42);
            this.btnBillSearch.TabIndex = 26;
            this.btnBillSearch.Text = "Search";
            this.btnBillSearch.UseVisualStyleBackColor = false;
            this.btnBillSearch.Click += new System.EventHandler(this.btnBillSearch_Click);
            // 
            // txtBillSearch
            // 
            this.txtBillSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBillSearch.Location = new System.Drawing.Point(229, 31);
            this.txtBillSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillSearch.Multiline = true;
            this.txtBillSearch.Name = "txtBillSearch";
            this.txtBillSearch.Size = new System.Drawing.Size(264, 41);
            this.txtBillSearch.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(63, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search Bill ID";
            // 
            // pnlFinal
            // 
            this.pnlFinal.BackColor = System.Drawing.Color.LightCoral;
            this.pnlFinal.Controls.Add(this.lblFinalCost);
            this.pnlFinal.Controls.Add(this.label7);
            this.pnlFinal.ForeColor = System.Drawing.Color.White;
            this.pnlFinal.Location = new System.Drawing.Point(801, 113);
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(431, 190);
            this.pnlFinal.TabIndex = 28;
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
            this.pnlTax.Location = new System.Drawing.Point(368, 113);
            this.pnlTax.Name = "pnlTax";
            this.pnlTax.Size = new System.Drawing.Size(392, 190);
            this.pnlTax.TabIndex = 29;
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
            this.pnlCharges.Location = new System.Drawing.Point(27, 113);
            this.pnlCharges.Name = "pnlCharges";
            this.pnlCharges.Size = new System.Drawing.Size(299, 190);
            this.pnlCharges.TabIndex = 30;
            // 
            // dgvBillBreakdown
            // 
            this.dgvBillBreakdown.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvBillBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillBreakdown.Location = new System.Drawing.Point(269, 349);
            this.dgvBillBreakdown.Name = "dgvBillBreakdown";
            this.dgvBillBreakdown.RowHeadersWidth = 51;
            this.dgvBillBreakdown.RowTemplate.Height = 24;
            this.dgvBillBreakdown.Size = new System.Drawing.Size(750, 250);
            this.dgvBillBreakdown.TabIndex = 31;
            // 
            // DisplayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 761);
            this.Controls.Add(this.dgvBillBreakdown);
            this.Controls.Add(this.pnlCharges);
            this.Controls.Add(this.pnlTax);
            this.Controls.Add(this.pnlFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBillSearch);
            this.Controls.Add(this.btnBillSearch);
            this.Controls.Add(this.btnMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayBill";
            this.Text = "Display Bill";
            this.Load += new System.EventHandler(this.DisplayBill_Load);
            this.pnlFinal.ResumeLayout(false);
            this.pnlFinal.PerformLayout();
            this.pnlTax.ResumeLayout(false);
            this.pnlTax.PerformLayout();
            this.pnlCharges.ResumeLayout(false);
            this.pnlCharges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblFinalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnBillSearch;
        private System.Windows.Forms.TextBox txtBillSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlFinal;
        private System.Windows.Forms.Panel pnlTax;
        private System.Windows.Forms.Panel pnlCharges;
        private System.Windows.Forms.DataGridView dgvBillBreakdown;
    }
}