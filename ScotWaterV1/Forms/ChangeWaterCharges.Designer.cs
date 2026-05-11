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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeWaterCharges));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
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
            this.comboChangeCharges.Location = new System.Drawing.Point(142, 124);
            this.comboChangeCharges.Name = "comboChangeCharges";
            this.comboChangeCharges.Size = new System.Drawing.Size(140, 25);
            this.comboChangeCharges.TabIndex = 1;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(142, 168);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(140, 25);
            this.txtNewPrice.TabIndex = 2;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangePrice.FlatAppearance.BorderSize = 0;
            this.btnChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePrice.ForeColor = System.Drawing.Color.White;
            this.btnChangePrice.Location = new System.Drawing.Point(35, 212);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(122, 40);
            this.btnChangePrice.TabIndex = 3;
            this.btnChangePrice.Text = "UPDATE PRICE";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // lblLowUsagePrice
            // 
            this.lblLowUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblLowUsagePrice.Location = new System.Drawing.Point(6, 25);
            this.lblLowUsagePrice.Name = "lblLowUsagePrice";
            this.lblLowUsagePrice.Size = new System.Drawing.Size(350, 23);
            this.lblLowUsagePrice.TabIndex = 4;
            this.lblLowUsagePrice.Text = "0–40 units :";
            // 
            // lblMediumUsagePrice
            // 
            this.lblMediumUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblMediumUsagePrice.Location = new System.Drawing.Point(6, 53);
            this.lblMediumUsagePrice.Name = "lblMediumUsagePrice";
            this.lblMediumUsagePrice.Size = new System.Drawing.Size(350, 23);
            this.lblMediumUsagePrice.TabIndex = 5;
            this.lblMediumUsagePrice.Text = "41–80 units :";
            // 
            // lblHighUsagePrice
            // 
            this.lblHighUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblHighUsagePrice.Location = new System.Drawing.Point(6, 81);
            this.lblHighUsagePrice.Name = "lblHighUsagePrice";
            this.lblHighUsagePrice.Size = new System.Drawing.Size(350, 28);
            this.lblHighUsagePrice.TabIndex = 6;
            this.lblHighUsagePrice.Text = "81+ units :";
            // 
            // lblDroughtLowUsagePrice
            // 
            this.lblDroughtLowUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroughtLowUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDroughtLowUsagePrice.Location = new System.Drawing.Point(6, 25);
            this.lblDroughtLowUsagePrice.Name = "lblDroughtLowUsagePrice";
            this.lblDroughtLowUsagePrice.Size = new System.Drawing.Size(350, 30);
            this.lblDroughtLowUsagePrice.TabIndex = 7;
            this.lblDroughtLowUsagePrice.Text = "0–40 units : ";
            // 
            // lblDroughtMediumUsagePrice
            // 
            this.lblDroughtMediumUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroughtMediumUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDroughtMediumUsagePrice.Location = new System.Drawing.Point(6, 50);
            this.lblDroughtMediumUsagePrice.Name = "lblDroughtMediumUsagePrice";
            this.lblDroughtMediumUsagePrice.Size = new System.Drawing.Size(350, 30);
            this.lblDroughtMediumUsagePrice.TabIndex = 8;
            this.lblDroughtMediumUsagePrice.Text = "41–80 units : ";
            // 
            // lblDroughtHighUsagePrice
            // 
            this.lblDroughtHighUsagePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroughtHighUsagePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDroughtHighUsagePrice.Location = new System.Drawing.Point(6, 81);
            this.lblDroughtHighUsagePrice.Name = "lblDroughtHighUsagePrice";
            this.lblDroughtHighUsagePrice.Size = new System.Drawing.Size(350, 40);
            this.lblDroughtHighUsagePrice.TabIndex = 9;
            this.lblDroughtHighUsagePrice.Text = "81+ units : ";
            // 
            // lblRecycledLowDiscount
            // 
            this.lblRecycledLowDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecycledLowDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblRecycledLowDiscount.Location = new System.Drawing.Point(6, 23);
            this.lblRecycledLowDiscount.Name = "lblRecycledLowDiscount";
            this.lblRecycledLowDiscount.Size = new System.Drawing.Size(350, 23);
            this.lblRecycledLowDiscount.TabIndex = 10;
            this.lblRecycledLowDiscount.Text = "0–5 units :";
            // 
            // lblMediumRecyclePrice
            // 
            this.lblMediumRecyclePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumRecyclePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblMediumRecyclePrice.Location = new System.Drawing.Point(6, 46);
            this.lblMediumRecyclePrice.Name = "lblMediumRecyclePrice";
            this.lblMediumRecyclePrice.Size = new System.Drawing.Size(218, 23);
            this.lblMediumRecyclePrice.TabIndex = 11;
            this.lblMediumRecyclePrice.Text = "41–80 units :";
            // 
            // lblHighRecyclePrice
            // 
            this.lblHighRecyclePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighRecyclePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblHighRecyclePrice.Location = new System.Drawing.Point(6, 76);
            this.lblHighRecyclePrice.Name = "lblHighRecyclePrice";
            this.lblHighRecyclePrice.Size = new System.Drawing.Size(218, 28);
            this.lblHighRecyclePrice.TabIndex = 12;
            this.lblHighRecyclePrice.Text = "21+ units : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLowUsagePrice);
            this.groupBox1.Controls.Add(this.lblHighUsagePrice);
            this.groupBox1.Controls.Add(this.lblMediumUsagePrice);
            this.groupBox1.Location = new System.Drawing.Point(399, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💧 Standard Freshwater Rates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDroughtLowUsagePrice);
            this.groupBox2.Controls.Add(this.lblDroughtHighUsagePrice);
            this.groupBox2.Controls.Add(this.lblDroughtMediumUsagePrice);
            this.groupBox2.Location = new System.Drawing.Point(399, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "💧 Low Reserve Freshwater Rates";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRecycledLowDiscount);
            this.groupBox3.Controls.Add(this.lblHighRecyclePrice);
            this.groupBox3.Controls.Add(this.lblMediumRecyclePrice);
            this.groupBox3.Location = new System.Drawing.Point(399, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 106);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "♻️ Recycling Discounts";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(234, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select a Charge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter Price";
            // 
            // frmChangeWaterCharges
            // 
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.comboChangeCharges);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.btnChangePrice);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChangeWaterCharges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Water Charges";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}