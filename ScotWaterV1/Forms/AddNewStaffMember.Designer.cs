using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ScotWaterV1.Forms
{
    partial class AddNewStaffMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStaffMember));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================
            this.panel1.BackColor = Color.FromArgb(0, 120, 215);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Size = new Size(1088, 125);

            this.pictureBox1.BackColor = Color.White;
            this.pictureBox1.Image = ((Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new Point(0, 0);
            this.pictureBox1.Size = new Size(182, 125);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            this.panel1.Controls.Add(this.pictureBox1);

            // ================= TEXTBOX USERNAME =================
            this.txtUsername.Font = new Font("Segoe UI", 11F);
            this.txtUsername.Location = new Point(320, 16);
            this.txtUsername.Size = new Size(260, 27);

            // ================= TEXTBOX PASSWORD =================
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(320, 57);
            this.txtPassword.Size = new Size(260, 27);
            this.txtPassword.UseSystemPasswordChar = true;

            // ================= LABELS =================
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 11F);
            this.label1.Location = new Point(20, 18);
            this.label1.Text = "Username:";

            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 11F);
            this.label2.Location = new Point(20, 60);
            this.label2.Text = "Password:";

            // ================= BUTTON =================
            this.btnSaveStaff.Text = "Save Staff Member";
            this.btnSaveStaff.Location = new Point(250, 110);
            this.btnSaveStaff.Size = new Size(200, 45);

            this.btnSaveStaff.FlatStyle = FlatStyle.Flat;
            this.btnSaveStaff.FlatAppearance.BorderSize = 0;
            this.btnSaveStaff.BackColor = Color.FromArgb(0, 120, 215);
            this.btnSaveStaff.ForeColor = Color.White;
            this.btnSaveStaff.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSaveStaff.Cursor = Cursors.Hand;

            

            // ================= PANEL =================
            this.panel2.BackColor = Color.White;
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            this.panel2.Location = new Point(117, 226);
            this.panel2.Size = new Size(750, 170);

            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.btnSaveStaff);

            // ================= FORM =================
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1088, 601);
            this.Text = "Add New Staff Member";

            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);

            this.Load += new EventHandler(this.Form_Load);

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // ================= ROUND BUTTON EFFECT =================
        private void Form_Load(object sender, EventArgs e)
        {
            btnSaveStaff.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSaveStaff.Width, btnSaveStaff.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btnSaveStaff;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}