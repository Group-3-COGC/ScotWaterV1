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
            this.btnChangeWaterCharges_SignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.txtWaterUsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRecycledWater = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddUsage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usage_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Water_Used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recycled_Water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // btnChangeWaterCharges_SignOut
            // 
            this.btnChangeWaterCharges_SignOut.BackColor = System.Drawing.Color.White;
            this.btnChangeWaterCharges_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWaterCharges_SignOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeWaterCharges_SignOut.Location = new System.Drawing.Point(685, 57);
            this.btnChangeWaterCharges_SignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeWaterCharges_SignOut.Name = "btnChangeWaterCharges_SignOut";
            this.btnChangeWaterCharges_SignOut.Size = new System.Drawing.Size(100, 35);
            this.btnChangeWaterCharges_SignOut.TabIndex = 20;
            this.btnChangeWaterCharges_SignOut.Text = "Sign Out";
            this.btnChangeWaterCharges_SignOut.UseVisualStyleBackColor = false;
            this.btnChangeWaterCharges_SignOut.Click += new System.EventHandler(this.btnChangeWaterCharges_SignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 104);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 544);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1134, 104);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.FormattingEnabled = true;
            this.CmbBusiness.Location = new System.Drawing.Point(348, 126);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(133, 21);
            this.CmbBusiness.TabIndex = 23;
            // 
            // txtWaterUsed
            // 
            this.txtWaterUsed.AutoSize = true;
            this.txtWaterUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterUsed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtWaterUsed.Location = new System.Drawing.Point(244, 182);
            this.txtWaterUsed.Name = "txtWaterUsed";
            this.txtWaterUsed.Size = new System.Drawing.Size(124, 24);
            this.txtWaterUsed.TabIndex = 24;
            this.txtWaterUsed.Text = "Water Used ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(244, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Recycled Water ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 26;
            // 
            // txtRecycledWater
            // 
            this.txtRecycledWater.Location = new System.Drawing.Point(413, 217);
            this.txtRecycledWater.Multiline = true;
            this.txtRecycledWater.Name = "txtRecycledWater";
            this.txtRecycledWater.Size = new System.Drawing.Size(114, 20);
            this.txtRecycledWater.TabIndex = 27;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(413, 260);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(114, 20);
            this.dtpDate.TabIndex = 28;
            // 
            // btnAddUsage
            // 
            this.btnAddUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUsage.Location = new System.Drawing.Point(348, 309);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(113, 33);
            this.btnAddUsage.TabIndex = 29;
            this.btnAddUsage.Text = "Add Usage ";
            this.btnAddUsage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usage_Date,
            this.Water_Used,
            this.Recycled_Water});
            this.dataGridView1.Location = new System.Drawing.Point(233, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 164);
            this.dataGridView1.TabIndex = 30;
            // 
            // Usage_Date
            // 
            this.Usage_Date.HeaderText = "Usage Date ";
            this.Usage_Date.Name = "Usage_Date";
            // 
            // Water_Used
            // 
            this.Water_Used.HeaderText = "Water Used";
            this.Water_Used.Name = "Water_Used";
            // 
            // Recycled_Water
            // 
            this.Recycled_Water.HeaderText = "Recycled Water ";
            this.Recycled_Water.Name = "Recycled_Water";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(244, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date";
            // 
            // BusinessWaterUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddUsage);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtRecycledWater);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWaterUsed);
            this.Controls.Add(this.CmbBusiness);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnChangeWaterCharges_SignOut);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BusinessWaterUsage";
            this.Text = "BusinessWaterUsage";
            this.Load += new System.EventHandler(this.Businmess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnChangeWaterCharges_SignOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CmbBusiness;
        private System.Windows.Forms.Label txtWaterUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtRecycledWater;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddUsage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usage_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Water_Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recycled_Water;
        private System.Windows.Forms.Label label1;
    }
}