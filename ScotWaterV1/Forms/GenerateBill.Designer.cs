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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateBill));
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.lblSelectBuisnessGB = new System.Windows.Forms.Label();
            this.lblGenerateBillsDate = new System.Windows.Forms.Label();
            this.cmbBusinessNames = new System.Windows.Forms.ComboBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.dgvBusinessesBill = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessesBill)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(460, 568);
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
            this.lblSelectBuisnessGB.Size = new System.Drawing.Size(129, 23);
            this.lblSelectBuisnessGB.TabIndex = 0;
            this.lblSelectBuisnessGB.Text = "Select Business";
            // 
            // lblGenerateBillsDate
            // 
            this.lblGenerateBillsDate.AutoSize = true;
            this.lblGenerateBillsDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenerateBillsDate.Location = new System.Drawing.Point(20, 60);
            this.lblGenerateBillsDate.Name = "lblGenerateBillsDate";
            this.lblGenerateBillsDate.Size = new System.Drawing.Size(101, 23);
            this.lblGenerateBillsDate.TabIndex = 1;
            this.lblGenerateBillsDate.Text = "Select Date";
            // 
            // cmbBusinessNames
            // 
            this.cmbBusinessNames.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBusinessNames.Location = new System.Drawing.Point(180, 18);
            this.cmbBusinessNames.Name = "cmbBusinessNames";
            this.cmbBusinessNames.Size = new System.Drawing.Size(250, 31);
            this.cmbBusinessNames.TabIndex = 2;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBillDate.Location = new System.Drawing.Point(180, 55);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(250, 30);
            this.dtpBillDate.TabIndex = 3;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelect.Controls.Add(this.lblSelectBuisnessGB);
            this.pnlSelect.Controls.Add(this.lblGenerateBillsDate);
            this.pnlSelect.Controls.Add(this.cmbBusinessNames);
            this.pnlSelect.Controls.Add(this.dtpBillDate);
            this.pnlSelect.Location = new System.Drawing.Point(186, 216);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(788, 121);
            this.pnlSelect.TabIndex = 1;
            // 
            // dgvBusinessesBill
            // 
            this.dgvBusinessesBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusinessesBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgvBusinessesBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusinessesBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusinessesBill.ColumnHeadersHeight = 29;
            this.dgvBusinessesBill.EnableHeadersVisualStyles = false;
            this.dgvBusinessesBill.GridColor = System.Drawing.Color.White;
            this.dgvBusinessesBill.Location = new System.Drawing.Point(186, 357);
            this.dgvBusinessesBill.Name = "dgvBusinessesBill";
            this.dgvBusinessesBill.ReadOnly = true;
            this.dgvBusinessesBill.RowHeadersWidth = 51;
            this.dgvBusinessesBill.RowTemplate.Height = 30;
            this.dgvBusinessesBill.Size = new System.Drawing.Size(788, 188);
            this.dgvBusinessesBill.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1431, 104);
            this.pnlHeader.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(243, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(439, 58);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Genereate a New Bill\r\n";
            // 
            // frmGenerateBill
            // 
            this.ClientSize = new System.Drawing.Size(1145, 687);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvBusinessesBill);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.btnGenerateBill);
            this.Name = "frmGenerateBill";
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessesBill)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateBill;

        private System.Windows.Forms.Label lblSelectBuisnessGB;
        private System.Windows.Forms.Label lblGenerateBillsDate;

        private System.Windows.Forms.ComboBox cmbBusinessNames;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Panel pnlSelect;

        private System.Windows.Forms.DataGridView dgvBusinessesBill;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
    }
}