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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmChangeWaterLevels));

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

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReserveLevel)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1088, 126);

            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Size = new System.Drawing.Size(182, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pnlHeader.Controls.Add(this.pictureBox3);

            // ================= GROUPBOX =================
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblWaterReserveStatus);
            this.groupBox1.Controls.Add(this.trkReserveLevel);
            this.groupBox1.Controls.Add(this.progressBarReserveLevel);
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.label1);

            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Size = new System.Drawing.Size(540, 280);
            this.groupBox1.Text = "WATER LEVELS";

            // LABELS
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Text = "Water Reserve Level";

            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(20, 150);
            this.lblValue.Text = "Water Reserve Status:";

            this.lblWaterReserveStatus.AutoSize = true;
            this.lblWaterReserveStatus.Location = new System.Drawing.Point(250, 150);
            this.lblWaterReserveStatus.Text = "";

            // PROGRESS BAR
            this.progressBarReserveLevel.Location = new System.Drawing.Point(240, 40);
            this.progressBarReserveLevel.Size = new System.Drawing.Size(270, 30);

            // TRACKBAR (RESTORED UI)
            this.trkReserveLevel.Location = new System.Drawing.Point(240, 90);
            this.trkReserveLevel.Maximum = 100;
            this.trkReserveLevel.Name = "trkReserveLevel";
            this.trkReserveLevel.Size = new System.Drawing.Size(291, 56);
            this.trkReserveLevel.TabIndex = 3;
            this.trkReserveLevel.Scroll += new System.EventHandler(this.trkReserveLevel_Scroll);
            // 
            // progressBarReserveLevel
            // 
            this.progressBarReserveLevel.Location = new System.Drawing.Point(241, 43);
            this.progressBarReserveLevel.Name = "progressBarReserveLevel";
            this.progressBarReserveLevel.Size = new System.Drawing.Size(268, 50);
            this.progressBarReserveLevel.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 158);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(230, 25);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Water Reserve Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water Reserve Level";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.White;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMainMenu.Location = new System.Drawing.Point(437, 479);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(133, 43);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "Main Menu ";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignOut.Location = new System.Drawing.Point(786, 43);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 35);
            this.btnSignOut.TabIndex = 18;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmChangeWaterLevels
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 601);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChangeWaterLevels";
            this.Text = "Change Water Levels";

            this.Load += new System.EventHandler(this.frmChangeWaterLevels_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReserveLevel)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWaterReserveStatus;
        private System.Windows.Forms.TrackBar trkReserveLevel;
        private System.Windows.Forms.ProgressBar progressBarReserveLevel;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSelect;
    }
}