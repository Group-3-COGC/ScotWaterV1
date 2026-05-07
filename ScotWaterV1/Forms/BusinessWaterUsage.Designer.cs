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
            this.btn_Show = new System.Windows.Forms.Button();
            this.btnShowUsage = new System.Windows.Forms.Button();
            this.btn_DeleteUsage = new System.Windows.Forms.Button();

            this.dgv_Business = new System.Windows.Forms.DataGridView();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Business)).BeginInit();
            this.SuspendLayout();

            // ================= HEADER =================
            this.panel1.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Size = new System.Drawing.Size(1088, 125);

            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(182, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.panel1.Controls.Add(this.pictureBox1);

            // ================= MAIN PANEL =================
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(83, 131);
            this.panel2.Size = new System.Drawing.Size(826, 277);

            // ComboBox
            this.CmbBusiness.Location = new System.Drawing.Point(318, 4);
            this.CmbBusiness.Size = new System.Drawing.Size(176, 21);

            // Labels
            this.txtWaterUsed.AutoSize = true;
            this.txtWaterUsed.Location = new System.Drawing.Point(160, 73);
            this.txtWaterUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtWaterUsed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtWaterUsed.Text = "Water Used";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 116);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Text = "Recycled Water";

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 167);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Text = "Date";

            // Textboxes
            this.txt_Water_Used.Location = new System.Drawing.Point(386, 73);
            this.txt_Water_Used.Size = new System.Drawing.Size(151, 24);

            this.txtRecycledWater.Location = new System.Drawing.Point(386, 116);
            this.txtRecycledWater.Size = new System.Drawing.Size(151, 24);

            // DateTimePicker
            this.dtpDate.Location = new System.Drawing.Point(386, 169);

            // Buttons
            this.btnAddUsage.Location = new System.Drawing.Point(299, 227);
            this.btnAddUsage.Size = new System.Drawing.Size(151, 41);
            this.btnAddUsage.Text = "Add Usage";

            this.btn_DeleteUsage.Location = new System.Drawing.Point(457, 227);
            this.btn_DeleteUsage.Size = new System.Drawing.Size(151, 41);
            this.btn_DeleteUsage.Text = "Delete Usage";

            this.btnShowUsage.Location = new System.Drawing.Point(640, 227);
            this.btnShowUsage.Size = new System.Drawing.Size(151, 41);
            this.btnShowUsage.Text = "Show Usage";

            this.btn_Show.Location = new System.Drawing.Point(531, 0);
            this.btn_Show.Size = new System.Drawing.Size(151, 41);
            this.btn_Show.Text = "Show Details";

            // Add controls
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

            // ================= DATA GRID =================
            this.dgv_Business.Location = new System.Drawing.Point(51, 415);
            this.dgv_Business.Size = new System.Drawing.Size(956, 180);
            this.dgv_Business.BackgroundColor = System.Drawing.Color.FromArgb(0, 120, 215);

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(1088, 601);
            this.BackColor = System.Drawing.Color.White;
            this.Text = "Business Water Usage";

            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Business);

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