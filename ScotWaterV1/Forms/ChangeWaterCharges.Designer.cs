using System.Drawing;

namespace ScotWaterV1.Forms
{
    partial class frmChangeWaterCharges
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLowUsagePrice = new System.Windows.Forms.Label();
            this.lblMediumUsagePrice = new System.Windows.Forms.Label();
            this.lblHighUsagePrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDroughtLowUsagePrice = new System.Windows.Forms.Label();
            this.lblDroughtMediumUsagePrice = new System.Windows.Forms.Label();
            this.lblDroughtHighUsagePrice = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRecycledLowDiscount = new System.Windows.Forms.Label();
            this.lblMediumRecyclePrice = new System.Windows.Forms.Label();
            this.lblHighRecyclePrice = new System.Windows.Forms.Label();
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
            this.pnlHeader.Size = new System.Drawing.Size(1145, 113);
            this.pnlHeader.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 114);
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
            this.lblTitle.Size = new System.Drawing.Size(308, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Change Water Charges";
            // 
            // comboChangeCharges
            // 
            this.comboChangeCharges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChangeCharges.Location = new System.Drawing.Point(209, 260);
            this.comboChangeCharges.Name = "comboChangeCharges";
            this.comboChangeCharges.Size = new System.Drawing.Size(204, 24);
            this.comboChangeCharges.TabIndex = 7;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(209, 345);
            this.txtNewPrice.Multiline = true;
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(203, 39);
            this.txtNewPrice.TabIndex = 6;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePrice.ForeColor = System.Drawing.Color.White;
            this.btnChangePrice.Location = new System.Drawing.Point(22, 423);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(144, 70);
            this.btnChangePrice.TabIndex = 5;
            this.btnChangePrice.Text = "UPDATE PRICE";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(233, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 70);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLowUsagePrice);
            this.groupBox1.Controls.Add(this.lblMediumUsagePrice);
            this.groupBox1.Controls.Add(this.lblHighUsagePrice);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.groupBox1.Location = new System.Drawing.Point(441, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Rates";
            // 
            // lblLowUsagePrice
            // 
            this.lblLowUsagePrice.Location = new System.Drawing.Point(6, 31);
            this.lblLowUsagePrice.Name = "lblLowUsagePrice";
            this.lblLowUsagePrice.Size = new System.Drawing.Size(307, 36);
            this.lblLowUsagePrice.TabIndex = 0;
            this.lblLowUsagePrice.Text = "0–40 units :";
            // 
            // lblMediumUsagePrice
            // 
            this.lblMediumUsagePrice.Location = new System.Drawing.Point(6, 67);
            this.lblMediumUsagePrice.Name = "lblMediumUsagePrice";
            this.lblMediumUsagePrice.Size = new System.Drawing.Size(296, 48);
            this.lblMediumUsagePrice.TabIndex = 1;
            this.lblMediumUsagePrice.Text = "41–80 units :";
            // 
            // lblHighUsagePrice
            // 
            this.lblHighUsagePrice.Location = new System.Drawing.Point(6, 110);
            this.lblHighUsagePrice.Name = "lblHighUsagePrice";
            this.lblHighUsagePrice.Size = new System.Drawing.Size(327, 34);
            this.lblHighUsagePrice.TabIndex = 2;
            this.lblHighUsagePrice.Text = "81+ units :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDroughtLowUsagePrice);
            this.groupBox2.Controls.Add(this.lblDroughtMediumUsagePrice);
            this.groupBox2.Controls.Add(this.lblDroughtHighUsagePrice);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.groupBox2.Location = new System.Drawing.Point(441, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reserve Rates";
            // 
            // lblDroughtLowUsagePrice
            // 
            this.lblDroughtLowUsagePrice.Location = new System.Drawing.Point(6, 40);
            this.lblDroughtLowUsagePrice.Name = "lblDroughtLowUsagePrice";
            this.lblDroughtLowUsagePrice.Size = new System.Drawing.Size(278, 40);
            this.lblDroughtLowUsagePrice.TabIndex = 0;
            this.lblDroughtLowUsagePrice.Text = "0–40 units :";
            // 
            // lblDroughtMediumUsagePrice
            // 
            this.lblDroughtMediumUsagePrice.Location = new System.Drawing.Point(6, 80);
            this.lblDroughtMediumUsagePrice.Name = "lblDroughtMediumUsagePrice";
            this.lblDroughtMediumUsagePrice.Size = new System.Drawing.Size(278, 38);
            this.lblDroughtMediumUsagePrice.TabIndex = 1;
            this.lblDroughtMediumUsagePrice.Text = "41–80 units :";
            // 
            // lblDroughtHighUsagePrice
            // 
            this.lblDroughtHighUsagePrice.Location = new System.Drawing.Point(6, 118);
            this.lblDroughtHighUsagePrice.Name = "lblDroughtHighUsagePrice";
            this.lblDroughtHighUsagePrice.Size = new System.Drawing.Size(278, 34);
            this.lblDroughtHighUsagePrice.TabIndex = 2;
            this.lblDroughtHighUsagePrice.Text = "81+ units :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRecycledLowDiscount);
            this.groupBox3.Controls.Add(this.lblMediumRecyclePrice);
            this.groupBox3.Controls.Add(this.lblHighRecyclePrice);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.groupBox3.Location = new System.Drawing.Point(441, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recycling Discounts";
            // 
            // lblRecycledLowDiscount
            // 
            this.lblRecycledLowDiscount.Location = new System.Drawing.Point(6, 35);
            this.lblRecycledLowDiscount.Name = "lblRecycledLowDiscount";
            this.lblRecycledLowDiscount.Size = new System.Drawing.Size(278, 35);
            this.lblRecycledLowDiscount.TabIndex = 0;
            this.lblRecycledLowDiscount.Text = "0–5 units :";
            this.lblRecycledLowDiscount.Click += new System.EventHandler(this.lblRecycledLowDiscount_Click);
            // 
            // lblMediumRecyclePrice
            // 
            this.lblMediumRecyclePrice.Location = new System.Drawing.Point(6, 70);
            this.lblMediumRecyclePrice.Name = "lblMediumRecyclePrice";
            this.lblMediumRecyclePrice.Size = new System.Drawing.Size(142, 37);
            this.lblMediumRecyclePrice.TabIndex = 1;
            this.lblMediumRecyclePrice.Text = "6–20 units :";
            // 
            // lblHighRecyclePrice
            // 
            this.lblHighRecyclePrice.Location = new System.Drawing.Point(6, 108);
            this.lblHighRecyclePrice.Name = "lblHighRecyclePrice";
            this.lblHighRecyclePrice.Size = new System.Drawing.Size(278, 38);
            this.lblHighRecyclePrice.TabIndex = 2;
            this.lblHighRecyclePrice.Text = "21+ units :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Charge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(27, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Price";
            // 
            // frmChangeWaterCharges
            // 
            this.ClientSize = new System.Drawing.Size(1145, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.comboChangeCharges);
            this.Controls.Add(this.pnlHeader);
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
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblLowUsagePrice;
        private System.Windows.Forms.Label lblMediumUsagePrice;
        private System.Windows.Forms.Label lblHighUsagePrice;

        private System.Windows.Forms.Label lblDroughtLowUsagePrice;
        private System.Windows.Forms.Label lblDroughtMediumUsagePrice;
        private System.Windows.Forms.Label lblDroughtHighUsagePrice;

        private System.Windows.Forms.Label lblRecycledLowDiscount;
        private System.Windows.Forms.Label lblMediumRecyclePrice;
        private System.Windows.Forms.Label lblHighRecyclePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}