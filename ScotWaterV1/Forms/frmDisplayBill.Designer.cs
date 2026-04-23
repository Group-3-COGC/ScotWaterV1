namespace ScotWaterV1.Forms
{
    partial class DisplayBill
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
            this.lblBillDetails = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBillDetails
            // 
            this.lblBillDetails.AutoSize = true;
            this.lblBillDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDetails.Location = new System.Drawing.Point(380, 41);
            this.lblBillDetails.Name = "lblBillDetails";
            this.lblBillDetails.Size = new System.Drawing.Size(165, 37);
            this.lblBillDetails.TabIndex = 0;
            this.lblBillDetails.Text = "Bill Details";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(44, 120);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(165, 25);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(44, 185);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(92, 25);
            this.lblBillDate.TabIndex = 2;
            this.lblBillDate.Text = "Bill Date";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(44, 245);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(147, 25);
            this.lblTotalCharges.TabIndex = 3;
            this.lblTotalCharges.Text = "Total Charges";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(44, 308);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 25);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(44, 363);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(91, 25);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(49, 417);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(53, 25);
            this.lblVAT.TabIndex = 6;
            this.lblVAT.Text = "VAT";
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.AutoSize = true;
            this.lblFinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCost.Location = new System.Drawing.Point(49, 469);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(109, 25);
            this.lblFinalCost.TabIndex = 7;
            this.lblFinalCost.Text = "Final Cost";
            // 
            // DisplayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.lblFinalCost);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblBillDetails);
            this.Name = "DisplayBill";
            this.Load += new System.EventHandler(this.DisplayBill_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillDetails;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblFinalCost;
    }
}