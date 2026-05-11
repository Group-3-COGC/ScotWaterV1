namespace ScotWaterV1.Forms
{
    partial class frmChangeWaterLevels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeWaterLevels));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWaterReserveStatus = new System.Windows.Forms.Label();
            this.trkReserveLevel = new System.Windows.Forms.TrackBar();
            this.progressBarReserveLevel = new System.Windows.Forms.ProgressBar();
            this.lblValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReserveLevel)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1088, 125);

            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Size = new System.Drawing.Size(182, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(243, 42);
            this.lblTitle.Text = "Change Water Levels";

            // ================= PANEL =================
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelect.Location = new System.Drawing.Point(250, 160);
            this.pnlSelect.Size = new System.Drawing.Size(580, 280);
            this.pnlSelect.Controls.Add(this.groupBox1);

            // ================= GROUPBOX =================
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblWaterReserveStatus);
            this.groupBox1.Controls.Add(this.trkReserveLevel);
            this.groupBox1.Controls.Add(this.progressBarReserveLevel);
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Size = new System.Drawing.Size(540, 260);
            this.groupBox1.Text = "WATER LEVELS";

            // ================= SAVE BUTTON (FIXED STYLE) =================
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(420, 210);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // ================= OTHER CONTROLS (UNCHANGED) =================
            this.lblWaterReserveStatus.AutoSize = true;
            this.trkReserveLevel.Maximum = 100;
            this.trkReserveLevel.Location = new System.Drawing.Point(230, 135);
            this.trkReserveLevel.Size = new System.Drawing.Size(290, 45);
            this.trkReserveLevel.Scroll += new System.EventHandler(this.trkReserveLevel_Scroll);

            this.progressBarReserveLevel.Location = new System.Drawing.Point(230, 40);
            this.progressBarReserveLevel.Size = new System.Drawing.Size(290, 40);

            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblValue.Location = new System.Drawing.Point(6, 135);
            this.lblValue.Text = "Water Reserve Status:";

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Text = "Water Reserve Level";

            // ================= FORM =================
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 601);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmChangeWaterLevels";
            this.Load += new System.EventHandler(this.frmChangeWaterLevels_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReserveLevel)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWaterReserveStatus;
        private System.Windows.Forms.TrackBar trkReserveLevel;
        private System.Windows.Forms.ProgressBar progressBarReserveLevel;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Label lblTitle;
    }
}