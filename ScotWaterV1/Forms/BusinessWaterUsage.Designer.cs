namespace ScotWaterV1.Forms
{
    partial class BusinessWaterUsage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessWaterUsage));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.txtWaterUsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Water_Used = new System.Windows.Forms.TextBox();
            this.txtRecycledWater = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddUsage = new System.Windows.Forms.Button();
            this.dgv_Business = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btnShowUsage = new System.Windows.Forms.Button();
            this.btn_DeleteUsage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1512, 128);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 670);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1512, 128);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.FormattingEnabled = true;
            this.CmbBusiness.Location = new System.Drawing.Point(483, 155);
            this.CmbBusiness.Margin = new System.Windows.Forms.Padding(4);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(176, 24);
            this.CmbBusiness.TabIndex = 23;
            // 
            // txtWaterUsed
            // 
            this.txtWaterUsed.AutoSize = true;
            this.txtWaterUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterUsed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtWaterUsed.Location = new System.Drawing.Point(325, 224);
            this.txtWaterUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWaterUsed.Name = "txtWaterUsed";
            this.txtWaterUsed.Size = new System.Drawing.Size(156, 29);
            this.txtWaterUsed.TabIndex = 24;
            this.txtWaterUsed.Text = "Water Used ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(325, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Recycled Water ";
            // 
            // txt_Water_Used
            // 
            this.txt_Water_Used.Location = new System.Drawing.Point(551, 224);
            this.txt_Water_Used.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Water_Used.Multiline = true;
            this.txt_Water_Used.Name = "txt_Water_Used";
            this.txt_Water_Used.Size = new System.Drawing.Size(151, 24);
            this.txt_Water_Used.TabIndex = 26;
            // 
            // txtRecycledWater
            // 
            this.txtRecycledWater.Location = new System.Drawing.Point(551, 267);
            this.txtRecycledWater.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecycledWater.Multiline = true;
            this.txtRecycledWater.Name = "txtRecycledWater";
            this.txtRecycledWater.Size = new System.Drawing.Size(151, 24);
            this.txtRecycledWater.TabIndex = 27;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(551, 320);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(151, 22);
            this.dtpDate.TabIndex = 28;
            // 
            // btnAddUsage
            // 
            this.btnAddUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUsage.Location = new System.Drawing.Point(464, 378);
            this.btnAddUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(151, 41);
            this.btnAddUsage.TabIndex = 29;
            this.btnAddUsage.Text = "Add Usage ";
            this.btnAddUsage.UseVisualStyleBackColor = true;
            this.btnAddUsage.Click += new System.EventHandler(this.btn_AddUsage_Click);
            // 
            // dgv_Business
            // 
            this.dgv_Business.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_Business.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Business.Location = new System.Drawing.Point(45, 442);
            this.dgv_Business.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Business.Name = "dgv_Business";
            this.dgv_Business.RowHeadersWidth = 51;
            this.dgv_Business.Size = new System.Drawing.Size(975, 202);
            this.dgv_Business.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(325, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date";
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Show.Location = new System.Drawing.Point(696, 146);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(151, 41);
            this.btn_Show.TabIndex = 32;
            this.btn_Show.Text = "Show Details ";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_ShowDetails_Click);
            // 
            // btnShowUsage
            // 
            this.btnShowUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUsage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowUsage.Location = new System.Drawing.Point(852, 394);
            this.btnShowUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowUsage.Name = "btnShowUsage";
            this.btnShowUsage.Size = new System.Drawing.Size(151, 41);
            this.btnShowUsage.TabIndex = 33;
            this.btnShowUsage.Text = "Show Usage ";
            this.btnShowUsage.UseVisualStyleBackColor = true;
            this.btnShowUsage.Click += new System.EventHandler(this.btn_ShowUsage_Click);
            // 
            // btn_DeleteUsage
            // 
            this.btn_DeleteUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUsage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DeleteUsage.Location = new System.Drawing.Point(622, 378);
            this.btn_DeleteUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteUsage.Name = "btn_DeleteUsage";
            this.btn_DeleteUsage.Size = new System.Drawing.Size(151, 41);
            this.btn_DeleteUsage.TabIndex = 35;
            this.btn_DeleteUsage.Text = "Delete Usage";
            this.btn_DeleteUsage.UseVisualStyleBackColor = true;
            this.btn_DeleteUsage.Click += new System.EventHandler(this.btn_DeleteUsage_Click);
            // 
            // BusinessWaterUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 601);
            this.Controls.Add(this.btn_DeleteUsage);
            this.Controls.Add(this.btnShowUsage);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Business);
            this.Controls.Add(this.btnAddUsage);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtRecycledWater);
            this.Controls.Add(this.txt_Water_Used);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWaterUsed);
            this.Controls.Add(this.CmbBusiness);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BusinessWaterUsage";
            this.Text = "BusinessWaterUsage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CmbBusiness;
        private System.Windows.Forms.Label txtWaterUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Water_Used;
        private System.Windows.Forms.TextBox txtRecycledWater;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddUsage;
        private System.Windows.Forms.DataGridView dgv_Business;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btnShowUsage;
        private System.Windows.Forms.Button btn_DeleteUsage;
    }
}