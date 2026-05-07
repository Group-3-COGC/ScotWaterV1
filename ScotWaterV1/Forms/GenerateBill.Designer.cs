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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.dgvBusinesses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinesses)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignOut.Location = new System.Drawing.Point(873, 11);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 35);
            this.btnSignOut.TabIndex = 17;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 551);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(996, 64);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.White;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMainMenu.Location = new System.Drawing.Point(454, 565);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 35);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main Menu ";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblSelectBuisnessGB
            // 
            this.lblSelectBuisnessGB.AutoSize = true;
            this.lblSelectBuisnessGB.Location = new System.Drawing.Point(101, 19);
            this.lblSelectBuisnessGB.Name = "lblSelectBuisnessGB";
            this.lblSelectBuisnessGB.Size = new System.Drawing.Size(92, 13);
            this.lblSelectBuisnessGB.TabIndex = 20;
            this.lblSelectBuisnessGB.Text = "Select A Buisness";
            // 
            // cmbBusinessNames
            // 
            this.cmbBusinessNames.FormattingEnabled = true;
            this.cmbBusinessNames.Location = new System.Drawing.Point(389, 16);
            this.cmbBusinessNames.Name = "cmbBusinessNames";
            this.cmbBusinessNames.Size = new System.Drawing.Size(121, 21);
            this.cmbBusinessNames.TabIndex = 21;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(389, 52);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBillDate.TabIndex = 26;
            // 
            // lblGenerateBillsDate
            // 
            this.lblGenerateBillsDate.AutoSize = true;
            this.lblGenerateBillsDate.Location = new System.Drawing.Point(102, 59);
            this.lblGenerateBillsDate.Name = "lblGenerateBillsDate";
            this.lblGenerateBillsDate.Size = new System.Drawing.Size(91, 13);
            this.lblGenerateBillsDate.TabIndex = 27;
            this.lblGenerateBillsDate.Text = "Select Date of Bill";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Location = new System.Drawing.Point(321, 434);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(179, 42);
            this.btnGenerateBill.TabIndex = 30;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click_1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Location = new System.Drawing.Point(0, 98);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(833, 42);
            this.pnlHeader.TabIndex = 31;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.lblSelectBuisnessGB);
            this.pnlSelect.Controls.Add(this.lblGenerateBillsDate);
            this.pnlSelect.Controls.Add(this.cmbBusinessNames);
            this.pnlSelect.Controls.Add(this.dtpBillDate);
            this.pnlSelect.Location = new System.Drawing.Point(0, 146);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(833, 85);
            this.pnlSelect.TabIndex = 32;
            // 
            // dgvBusinesses
            // 
            this.dgvBusinesses.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvBusinesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinesses.Location = new System.Drawing.Point(96, 252);
            this.dgvBusinesses.Name = "dgvBusinesses";
            this.dgvBusinesses.ReadOnly = true;
            this.dgvBusinesses.RowHeadersWidth = 51;
            this.dgvBusinesses.Size = new System.Drawing.Size(614, 146);
            this.dgvBusinesses.TabIndex = 33;
            // 
            // frmGenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 488);
            this.Controls.Add(this.dgvBusinesses);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGenerateBill";
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinesses)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.DataGridView dgvBusinesses;
    }
}