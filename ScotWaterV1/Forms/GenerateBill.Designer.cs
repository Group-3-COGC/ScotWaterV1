namespace ScotWaterV1.Forms
{
    partial class frmGenerateBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateBill));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblSelectBuisnessGB = new System.Windows.Forms.Label();
            this.cmbBusinessNames = new System.Windows.Forms.ComboBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblGenerateBillsDate = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1315, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignOut.Location = new System.Drawing.Point(1164, 14);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(133, 43);
            this.btnSignOut.TabIndex = 17;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 678);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1328, 79);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.White;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMainMenu.Location = new System.Drawing.Point(605, 695);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(133, 43);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main Menu ";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblSelectBuisnessGB
            // 
            this.lblSelectBuisnessGB.AutoSize = true;
            this.lblSelectBuisnessGB.Location = new System.Drawing.Point(49, 245);
            this.lblSelectBuisnessGB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectBuisnessGB.Name = "lblSelectBuisnessGB";
            this.lblSelectBuisnessGB.Size = new System.Drawing.Size(115, 16);
            this.lblSelectBuisnessGB.TabIndex = 20;
            this.lblSelectBuisnessGB.Text = "Select A Buisness";
            // 
            // cmbBusinessNames
            // 
            this.cmbBusinessNames.FormattingEnabled = true;
            this.cmbBusinessNames.Location = new System.Drawing.Point(225, 235);
            this.cmbBusinessNames.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBusinessNames.Name = "cmbBusinessNames";
            this.cmbBusinessNames.Size = new System.Drawing.Size(160, 24);
            this.cmbBusinessNames.TabIndex = 21;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(225, 297);
            this.dtpBillDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(265, 22);
            this.dtpBillDate.TabIndex = 26;
            // 
            // lblGenerateBillsDate
            // 
            this.lblGenerateBillsDate.AutoSize = true;
            this.lblGenerateBillsDate.Location = new System.Drawing.Point(49, 297);
            this.lblGenerateBillsDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerateBillsDate.Name = "lblGenerateBillsDate";
            this.lblGenerateBillsDate.Size = new System.Drawing.Size(112, 16);
            this.lblGenerateBillsDate.TabIndex = 27;
            this.lblGenerateBillsDate.Text = "Select Date of Bill";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Location = new System.Drawing.Point(537, 192);
            this.btnGenerateBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(239, 121);
            this.btnGenerateBill.TabIndex = 30;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click_1);
            // 
            // frmGenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 601);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.lblGenerateBillsDate);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.cmbBusinessNames);
            this.Controls.Add(this.lblSelectBuisnessGB);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGenerateBill";
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblSelectBuisnessGB;
        private System.Windows.Forms.ComboBox cmbBusinessNames;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label lblGenerateBillsDate;
        private System.Windows.Forms.Button btnGenerateBill;
    }
}