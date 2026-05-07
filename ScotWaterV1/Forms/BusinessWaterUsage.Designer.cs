namespace ScotWaterV1.Forms
{
    partial class BusinessWaterUsage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessWaterUsage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.txtWaterUsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Water_Used = new System.Windows.Forms.TextBox();
            this.txtRecycledWater = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddUsage = new System.Windows.Forms.Button();
            this.btn_DeleteUsage = new System.Windows.Forms.Button();
            this.btnShowUsage = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.dgv_Business = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 125);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CmbBusiness);
            this.panel2.Controls.Add(this.txtWaterUsed);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Water_Used);
            this.panel2.Controls.Add(this.txtRecycledWater);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.btnAddUsage);
            this.panel2.Controls.Add(this.btn_DeleteUsage);
            this.panel2.Controls.Add(this.btnShowUsage);
            this.panel2.Controls.Add(this.btn_Show);
            this.panel2.Location = new System.Drawing.Point(83, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 277);
            this.panel2.TabIndex = 0;
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBusiness.Location = new System.Drawing.Point(318, 4);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(176, 21);
            this.CmbBusiness.TabIndex = 0;
            // 
            // txtWaterUsed
            // 
            this.txtWaterUsed.AutoSize = true;
            this.txtWaterUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtWaterUsed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtWaterUsed.Location = new System.Drawing.Point(160, 73);
            this.txtWaterUsed.Name = "txtWaterUsed";
            this.txtWaterUsed.Size = new System.Drawing.Size(118, 24);
            this.txtWaterUsed.TabIndex = 1;
            this.txtWaterUsed.Text = "Water Used";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(160, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recycled Water";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(160, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // txt_Water_Used
            // 
            this.txt_Water_Used.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Water_Used.Location = new System.Drawing.Point(386, 73);
            this.txt_Water_Used.Name = "txt_Water_Used";
            this.txt_Water_Used.Size = new System.Drawing.Size(151, 20);
            this.txt_Water_Used.TabIndex = 4;
            // 
            // txtRecycledWater
            // 
            this.txtRecycledWater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecycledWater.Location = new System.Drawing.Point(386, 116);
            this.txtRecycledWater.Name = "txtRecycledWater";
            this.txtRecycledWater.Size = new System.Drawing.Size(151, 20);
            this.txtRecycledWater.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(386, 169);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // btnAddUsage
            // 
            this.btnAddUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddUsage.FlatAppearance.BorderSize = 0;
            this.btnAddUsage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.btnAddUsage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnAddUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsage.ForeColor = System.Drawing.Color.White;
            this.btnAddUsage.Location = new System.Drawing.Point(299, 227);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(151, 41);
            this.btnAddUsage.TabIndex = 7;
            this.btnAddUsage.Text = "Add Usage";
            this.btnAddUsage.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteUsage
            // 
            this.btn_DeleteUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_DeleteUsage.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUsage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_DeleteUsage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_DeleteUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUsage.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteUsage.Location = new System.Drawing.Point(457, 227);
            this.btn_DeleteUsage.Name = "btn_DeleteUsage";
            this.btn_DeleteUsage.Size = new System.Drawing.Size(151, 41);
            this.btn_DeleteUsage.TabIndex = 8;
            this.btn_DeleteUsage.Text = "Delete Usage";
            this.btn_DeleteUsage.UseVisualStyleBackColor = false;
            // 
            // btnShowUsage
            // 
            this.btnShowUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnShowUsage.FlatAppearance.BorderSize = 0;
            this.btnShowUsage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.btnShowUsage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnShowUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUsage.ForeColor = System.Drawing.Color.White;
            this.btnShowUsage.Location = new System.Drawing.Point(640, 227);
            this.btnShowUsage.Name = "btnShowUsage";
            this.btnShowUsage.Size = new System.Drawing.Size(151, 41);
            this.btnShowUsage.TabIndex = 9;
            this.btnShowUsage.Text = "Show Usage";
            this.btnShowUsage.UseVisualStyleBackColor = false;
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_Show.FlatAppearance.BorderSize = 0;
            this.btn_Show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.ForeColor = System.Drawing.Color.White;
            this.btn_Show.Location = new System.Drawing.Point(531, 0);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(151, 41);
            this.btn_Show.TabIndex = 10;
            this.btn_Show.Text = "Show Details";
            this.btn_Show.UseVisualStyleBackColor = false;
            // 
            // dgv_Business
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgv_Business.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Business.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgv_Business.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Business.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Business.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Business.EnableHeadersVisualStyles = false;
            this.dgv_Business.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Business.Location = new System.Drawing.Point(51, 415);
            this.dgv_Business.Name = "dgv_Business";
            this.dgv_Business.Size = new System.Drawing.Size(956, 180);
            this.dgv_Business.TabIndex = 2;
            // 
            // BusinessWaterUsage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Business);
            this.Name = "BusinessWaterUsage";
            this.Text = "Business Water Usage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.ComboBox CmbBusiness;

        private System.Windows.Forms.Label txtWaterUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txt_Water_Used;
        private System.Windows.Forms.TextBox txtRecycledWater;

        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.Button btnAddUsage;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btnShowUsage;
        private System.Windows.Forms.Button btn_DeleteUsage;

        private System.Windows.Forms.DataGridView dgv_Business;
    }
}