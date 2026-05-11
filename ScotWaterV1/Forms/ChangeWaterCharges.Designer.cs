using System.Drawing;

namespace ScotWaterV1.Forms
{
    partial class frmChangeWaterCharges
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboChangeCharges = new System.Windows.Forms.ComboBox();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.lblLowUsagePrice = new System.Windows.Forms.Label();
            this.lblMediumUsagePrice = new System.Windows.Forms.Label();
            this.lblHighUsagePrice = new System.Windows.Forms.Label();
            this.lblDroughtLowUsagePrice = new System.Windows.Forms.Label();
            this.lblDroughtMediumUsagePrice = new System.Windows.Forms.Label();
            this.lblDroughtHighUsagePrice = new System.Windows.Forms.Label();
            this.lblRecycledLowDiscount = new System.Windows.Forms.Label();
            this.lblMediumRecyclePrice = new System.Windows.Forms.Label();
            this.lblHighRecyclePrice = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(150, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Change Water Charges";
            // 
            // comboChangeCharges
            // 
            this.comboChangeCharges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboChangeCharges.Location = new System.Drawing.Point(50, 120);
            this.comboChangeCharges.Name = "comboChangeCharges";
            this.comboChangeCharges.Size = new System.Drawing.Size(280, 25);
            this.comboChangeCharges.TabIndex = 1;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(50, 160);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(280, 25);
            this.txtNewPrice.TabIndex = 2;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangePrice.FlatAppearance.BorderSize = 0;
            this.btnChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePrice.ForeColor = System.Drawing.Color.White;
            this.btnChangePrice.Location = new System.Drawing.Point(50, 200);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(280, 40);
            this.btnChangePrice.TabIndex = 3;
            this.btnChangePrice.Text = "UPDATE PRICE";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // lblLowUsagePrice
            // 
            this.lblLowUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblLowUsagePrice.Location = new System.Drawing.Point(400, 120);
            this.lblLowUsagePrice.Name = "lblLowUsagePrice";
            this.lblLowUsagePrice.Size = new System.Drawing.Size(223, 23);
            this.lblLowUsagePrice.TabIndex = 4;
            this.lblLowUsagePrice.Text = "Normal Low: £0.00";
            // 
            // lblMediumUsagePrice
            // 
            this.lblMediumUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblMediumUsagePrice.Location = new System.Drawing.Point(400, 150);
            this.lblMediumUsagePrice.Name = "lblMediumUsagePrice";
            this.lblMediumUsagePrice.Size = new System.Drawing.Size(223, 23);
            this.lblMediumUsagePrice.TabIndex = 5;
            this.lblMediumUsagePrice.Text = "Normal Medium: £0.00";
            // 
            // lblHighUsagePrice
            // 
            this.lblHighUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblHighUsagePrice.Location = new System.Drawing.Point(400, 180);
            this.lblHighUsagePrice.Name = "lblHighUsagePrice";
            this.lblHighUsagePrice.Size = new System.Drawing.Size(223, 23);
            this.lblHighUsagePrice.TabIndex = 6;
            this.lblHighUsagePrice.Text = "Normal High: £0.00";
            // 
            // lblDroughtLowUsagePrice
            // 
            this.lblDroughtLowUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroughtLowUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDroughtLowUsagePrice.Location = new System.Drawing.Point(400, 220);
            this.lblDroughtLowUsagePrice.Name = "lblDroughtLowUsagePrice";
            this.lblDroughtLowUsagePrice.Size = new System.Drawing.Size(201, 30);
            this.lblDroughtLowUsagePrice.TabIndex = 7;
            this.lblDroughtLowUsagePrice.Text = "Drought Low: £0.00";
            // 
            // lblDroughtMediumUsagePrice
            // 
            this.lblDroughtMediumUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroughtMediumUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDroughtMediumUsagePrice.Location = new System.Drawing.Point(400, 250);
            this.lblDroughtMediumUsagePrice.Name = "lblDroughtMediumUsagePrice";
            this.lblDroughtMediumUsagePrice.Size = new System.Drawing.Size(236, 30);
            this.lblDroughtMediumUsagePrice.TabIndex = 8;
            this.lblDroughtMediumUsagePrice.Text = "Drought Medium: £0.00";
            // 
            // lblDroughtHighUsagePrice
            // 
            this.lblDroughtHighUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroughtHighUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDroughtHighUsagePrice.Location = new System.Drawing.Point(400, 280);
            this.lblDroughtHighUsagePrice.Name = "lblDroughtHighUsagePrice";
            this.lblDroughtHighUsagePrice.Size = new System.Drawing.Size(223, 40);
            this.lblDroughtHighUsagePrice.TabIndex = 9;
            this.lblDroughtHighUsagePrice.Text = "Drought High: £0.00";
            // 
            // lblRecycledLowDiscount
            // 
            this.lblRecycledLowDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecycledLowDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblRecycledLowDiscount.Location = new System.Drawing.Point(400, 320);
            this.lblRecycledLowDiscount.Name = "lblRecycledLowDiscount";
            this.lblRecycledLowDiscount.Size = new System.Drawing.Size(201, 23);
            this.lblRecycledLowDiscount.TabIndex = 10;
            this.lblRecycledLowDiscount.Text = "Recycled Low: £0.00";
            // 
            // lblMediumRecyclePrice
            // 
            this.lblMediumRecyclePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumRecyclePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblMediumRecyclePrice.Location = new System.Drawing.Point(400, 350);
            this.lblMediumRecyclePrice.Name = "lblMediumRecyclePrice";
            this.lblMediumRecyclePrice.Size = new System.Drawing.Size(257, 23);
            this.lblMediumRecyclePrice.TabIndex = 11;
            this.lblMediumRecyclePrice.Text = "Recycled Medium: £0.00";
            // 
            // lblHighRecyclePrice
            // 
            this.lblHighRecyclePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighRecyclePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblHighRecyclePrice.Location = new System.Drawing.Point(400, 380);
            this.lblHighRecyclePrice.Name = "lblHighRecyclePrice";
            this.lblHighRecyclePrice.Size = new System.Drawing.Size(241, 23);
            this.lblHighRecyclePrice.TabIndex = 12;
            this.lblHighRecyclePrice.Text = "Recycled High: £0.00";
            // 
            // frmChangeWaterCharges
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.comboChangeCharges);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.lblLowUsagePrice);
            this.Controls.Add(this.lblMediumUsagePrice);
            this.Controls.Add(this.lblHighUsagePrice);
            this.Controls.Add(this.lblDroughtLowUsagePrice);
            this.Controls.Add(this.lblDroughtMediumUsagePrice);
            this.Controls.Add(this.lblDroughtHighUsagePrice);
            this.Controls.Add(this.lblRecycledLowDiscount);
            this.Controls.Add(this.lblMediumRecyclePrice);
            this.Controls.Add(this.lblHighRecyclePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChangeWaterCharges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Water Charges";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.ComboBox comboChangeCharges;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button btnChangePrice;

        private System.Windows.Forms.Label lblLowUsagePrice;
        private System.Windows.Forms.Label lblMediumUsagePrice;
        private System.Windows.Forms.Label lblHighUsagePrice;

        private System.Windows.Forms.Label lblDroughtLowUsagePrice;
        private System.Windows.Forms.Label lblDroughtMediumUsagePrice;
        private System.Windows.Forms.Label lblDroughtHighUsagePrice;

        private System.Windows.Forms.Label lblRecycledLowDiscount;
        private System.Windows.Forms.Label lblMediumRecyclePrice;
        private System.Windows.Forms.Label lblHighRecyclePrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}