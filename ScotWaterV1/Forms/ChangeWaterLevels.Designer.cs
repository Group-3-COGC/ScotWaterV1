using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterLevels : Form
    {

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeWaterLevels));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWaterReserveStatus = new System.Windows.Forms.Label();
            this.trkReserveLevel = new System.Windows.Forms.TrackBar();
            this.progressBarReserveLevel = new System.Windows.Forms.ProgressBar();
            this.lblValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnM_R_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReserveLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-29, 453);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1001, 125);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-29, -33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 159);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblWaterReserveStatus);
            this.groupBox1.Controls.Add(this.trkReserveLevel);
            this.groupBox1.Controls.Add(this.progressBarReserveLevel);
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(44, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 268);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WATER LEVELS";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(403, 214);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWaterReserveStatus
            // 
            this.lblWaterReserveStatus.AutoSize = true;
            this.lblWaterReserveStatus.Location = new System.Drawing.Point(256, 158);
            this.lblWaterReserveStatus.Name = "lblWaterReserveStatus";
            this.lblWaterReserveStatus.Size = new System.Drawing.Size(0, 20);
            this.lblWaterReserveStatus.TabIndex = 4;
            // 
            // trkReserveLevel
            // 
            this.trkReserveLevel.Location = new System.Drawing.Point(229, 99);
            this.trkReserveLevel.Maximum = 100;
            this.trkReserveLevel.Name = "trkReserveLevel";
            this.trkReserveLevel.Size = new System.Drawing.Size(291, 45);
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
            this.lblValue.Size = new System.Drawing.Size(191, 20);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Water Reserve Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water Reserve Level";
            // 
            // btnM_R_MainMenu
            // 
            this.btnM_R_MainMenu.BackColor = System.Drawing.Color.White;
            this.btnM_R_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_R_MainMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnM_R_MainMenu.Location = new System.Drawing.Point(437, 479);
            this.btnM_R_MainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnM_R_MainMenu.Name = "btnM_R_MainMenu";
            this.btnM_R_MainMenu.Size = new System.Drawing.Size(133, 43);
            this.btnM_R_MainMenu.TabIndex = 13;
            this.btnM_R_MainMenu.Text = "Main Menu ";
            this.btnM_R_MainMenu.UseVisualStyleBackColor = false;
            // 
            // frmChangeWaterLevels
            // 
            this.ClientSize = new System.Drawing.Size(943, 544);
            this.Controls.Add(this.btnM_R_MainMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChangeWaterLevels";
            this.Load += new System.EventHandler(this.frmChangeWaterLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReserveLevel)).EndInit();
            this.ResumeLayout(false);

        }






        // SIGN OUT
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        // MAIN MENU
        private void btnChangeWaterCharges_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label lblWaterReserveStatus;
        private TrackBar trkReserveLevel;
        private ProgressBar progressBarReserveLevel;
        private Label lblValue;
        private Label label1;
        private Button btnSave;
        private Button btnM_R_MainMenu;
    }
}