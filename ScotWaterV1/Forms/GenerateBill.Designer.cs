namespace ScotWaterV1.Forms
{
    partial class frmGenerateBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.lblSelectBuisnessGB = new System.Windows.Forms.Label();
            this.lblGenerateBillsDate = new System.Windows.Forms.Label();
            this.cmbBusinessNames = new System.Windows.Forms.ComboBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.dgvBusinessesBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessesBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 104);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 551);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(996, 64);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(454, 565);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 35);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(320, 420);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(180, 45);
            this.btnGenerateBill.TabIndex = 3;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click_1);
            // 
            // lblSelectBuisnessGB
            // 
            this.lblSelectBuisnessGB.AutoSize = true;
            this.lblSelectBuisnessGB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectBuisnessGB.Location = new System.Drawing.Point(20, 20);
            this.lblSelectBuisnessGB.Name = "lblSelectBuisnessGB";
            this.lblSelectBuisnessGB.Size = new System.Drawing.Size(108, 19);
            this.lblSelectBuisnessGB.TabIndex = 0;
            this.lblSelectBuisnessGB.Text = "Select Business";
            // 
            // lblGenerateBillsDate
            // 
            this.lblGenerateBillsDate.AutoSize = true;
            this.lblGenerateBillsDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenerateBillsDate.Location = new System.Drawing.Point(20, 60);
            this.lblGenerateBillsDate.Name = "lblGenerateBillsDate";
            this.lblGenerateBillsDate.Size = new System.Drawing.Size(84, 19);
            this.lblGenerateBillsDate.TabIndex = 1;
            this.lblGenerateBillsDate.Text = "Select Date";
            // 
            // cmbBusinessNames
            // 
            this.cmbBusinessNames.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBusinessNames.Location = new System.Drawing.Point(180, 18);
            this.cmbBusinessNames.Name = "cmbBusinessNames";
            this.cmbBusinessNames.Size = new System.Drawing.Size(250, 25);
            this.cmbBusinessNames.TabIndex = 2;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBillDate.Location = new System.Drawing.Point(180, 55);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(250, 25);
            this.dtpBillDate.TabIndex = 3;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(833, 80);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelect.Controls.Add(this.lblSelectBuisnessGB);
            this.pnlSelect.Controls.Add(this.lblGenerateBillsDate);
            this.pnlSelect.Controls.Add(this.cmbBusinessNames);
            this.pnlSelect.Controls.Add(this.dtpBillDate);
            this.pnlSelect.Location = new System.Drawing.Point(40, 110);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(750, 100);
            this.pnlSelect.TabIndex = 1;
            // 
            // dgvBusinessesBill
            // 
            this.dgvBusinessesBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusinessesBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusinessesBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusinessesBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusinessesBill.EnableHeadersVisualStyles = false;
            this.dgvBusinessesBill.GridColor = System.Drawing.Color.LightGray;
            this.dgvBusinessesBill.Location = new System.Drawing.Point(40, 230);
            this.dgvBusinessesBill.Name = "dgvBusinessesBill";
            this.dgvBusinessesBill.ReadOnly = true;
            this.dgvBusinessesBill.RowHeadersWidth = 51;
            this.dgvBusinessesBill.RowTemplate.Height = 30;
            this.dgvBusinessesBill.Size = new System.Drawing.Size(750, 170);
            this.dgvBusinessesBill.TabIndex = 0;
            // 
            // frmGenerateBill
            // 
            this.ClientSize = new System.Drawing.Size(833, 488);
            this.Controls.Add(this.dgvBusinessesBill);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerateBill";
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessesBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnGenerateBill;

        private System.Windows.Forms.Label lblSelectBuisnessGB;
        private System.Windows.Forms.Label lblGenerateBillsDate;

        private System.Windows.Forms.ComboBox cmbBusinessNames;
        private System.Windows.Forms.DateTimePicker dtpBillDate;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSelect;

        private System.Windows.Forms.DataGridView dgvBusinessesBill;
    }
}