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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.txtWaterUsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Water_Used = new System.Windows.Forms.TextBox();
            this.txtRecycledWater = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddUsage = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btnShowUsage = new System.Windows.Forms.Button();
            this.btn_DeleteUsage = new System.Windows.Forms.Button();
            this.dgv_Business = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.Location = new System.Drawing.Point(330, 15);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(140, 21);
            this.CmbBusiness.TabIndex = 6;
            // 
            // txtWaterUsed
            // 
            this.txtWaterUsed.AutoSize = true;
            this.txtWaterUsed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtWaterUsed.Location = new System.Drawing.Point(20, 15);
            this.txtWaterUsed.Name = "txtWaterUsed";
            this.txtWaterUsed.Size = new System.Drawing.Size(86, 19);
            this.txtWaterUsed.TabIndex = 0;
            this.txtWaterUsed.Text = "Water Used";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recycled Water";
            // 
            // txt_Water_Used
            // 
            this.txt_Water_Used.Location = new System.Drawing.Point(180, 15);
            this.txt_Water_Used.Name = "txt_Water_Used";
            this.txt_Water_Used.Size = new System.Drawing.Size(120, 20);
            this.txt_Water_Used.TabIndex = 3;
            // 
            // txtRecycledWater
            // 
            this.txtRecycledWater.Location = new System.Drawing.Point(180, 45);
            this.txtRecycledWater.Name = "txtRecycledWater";
            this.txtRecycledWater.Size = new System.Drawing.Size(120, 20);
            this.txtRecycledWater.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(180, 75);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // btnAddUsage
            // 
            this.btnAddUsage.Location = new System.Drawing.Point(500, 15);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(100, 30);
            this.btnAddUsage.TabIndex = 7;
            this.btnAddUsage.Text = "Add";
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(500, 50);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(100, 30);
            this.btn_Show.TabIndex = 8;
            this.btn_Show.Text = "Show";
            // 
            // btnShowUsage
            // 
            this.btnShowUsage.Location = new System.Drawing.Point(610, 15);
            this.btnShowUsage.Name = "btnShowUsage";
            this.btnShowUsage.Size = new System.Drawing.Size(100, 30);
            this.btnShowUsage.TabIndex = 9;
            this.btnShowUsage.Text = "Usage";
            // 
            // btn_DeleteUsage
            // 
            this.btn_DeleteUsage.Location = new System.Drawing.Point(610, 50);
            this.btn_DeleteUsage.Name = "btn_DeleteUsage";
            this.btn_DeleteUsage.Size = new System.Drawing.Size(100, 30);
            this.btn_DeleteUsage.TabIndex = 10;
            this.btn_DeleteUsage.Text = "Delete";
            // 
            // dgv_Business
            // 
            this.dgv_Business.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_Business.Location = new System.Drawing.Point(30, 260);
            this.dgv_Business.Name = "dgv_Business";
            this.dgv_Business.Size = new System.Drawing.Size(750, 180);
            this.dgv_Business.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(816, 90);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelect.Controls.Add(this.txtWaterUsed);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.label1);
            this.pnlSelect.Controls.Add(this.txt_Water_Used);
            this.pnlSelect.Controls.Add(this.txtRecycledWater);
            this.pnlSelect.Controls.Add(this.dtpDate);
            this.pnlSelect.Controls.Add(this.CmbBusiness);
            this.pnlSelect.Controls.Add(this.btnAddUsage);
            this.pnlSelect.Controls.Add(this.btn_Show);
            this.pnlSelect.Controls.Add(this.btnShowUsage);
            this.pnlSelect.Controls.Add(this.btn_DeleteUsage);
            this.pnlSelect.Location = new System.Drawing.Point(30, 120);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(750, 120);
            this.pnlSelect.TabIndex = 0;
            // 
            // BusinessWaterUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 488);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgv_Business);
            this.Name = "BusinessWaterUsage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Water Usage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;

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

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSelect;
    }
}