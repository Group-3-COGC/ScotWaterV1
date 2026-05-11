using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    partial class frmAddBusiness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBusiness));
            this.btnAddNewBusiness = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();

            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.txtBusinessID = new System.Windows.Forms.TextBox();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();

            Color mainBlue = System.Drawing.Color.FromArgb(0, 102, 204);

            // ================= HEADER =================
            this.pnlHeader.BackColor = mainBlue;
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(950, 90);

            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Size = new System.Drawing.Size(170, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // ================= PANEL =================
            this.pnlSelect.BackColor = System.Drawing.Color.White;
            this.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelect.Location = new System.Drawing.Point(35, 120);
            this.pnlSelect.Size = new System.Drawing.Size(875, 300);

            Font lblFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            Font txtFont = new System.Drawing.Font("Segoe UI", 10F);

            // ================= LABELS (NO LOOPS) =================
            this.label1.Text = "Business ID";
            this.label2.Text = "Business Name";
            this.label3.Text = "City";
            this.label4.Text = "Address Line 1";
            this.label5.Text = "Address Line 2";
            this.label6.Text = "Postcode";
            this.label7.Text = "Region";
            this.label8.Text = "Phone Number";
            this.label9.Text = "Contact Name";
            this.label10.Text = "Email Address";
            this.label11.Text = "Account Name";
            this.label12.Text = "Sort Code";
            this.label13.Text = "Account Number";

            this.label1.Font = lblFont; this.label1.ForeColor = mainBlue;
            this.label2.Font = lblFont; this.label2.ForeColor = mainBlue;
            this.label3.Font = lblFont; this.label3.ForeColor = mainBlue;
            this.label4.Font = lblFont; this.label4.ForeColor = mainBlue;
            this.label5.Font = lblFont; this.label5.ForeColor = mainBlue;
            this.label6.Font = lblFont; this.label6.ForeColor = mainBlue;
            this.label7.Font = lblFont; this.label7.ForeColor = mainBlue;
            this.label8.Font = lblFont; this.label8.ForeColor = mainBlue;
            this.label9.Font = lblFont; this.label9.ForeColor = mainBlue;
            this.label10.Font = lblFont; this.label10.ForeColor = mainBlue;
            this.label11.Font = lblFont; this.label11.ForeColor = mainBlue;
            this.label12.Font = lblFont; this.label12.ForeColor = mainBlue;
            this.label13.Font = lblFont; this.label13.ForeColor = mainBlue;

            this.label1.AutoSize = this.label2.AutoSize = this.label3.AutoSize =
            this.label4.AutoSize = this.label5.AutoSize = this.label6.AutoSize =
            this.label7.AutoSize = this.label8.AutoSize = this.label9.AutoSize =
            this.label10.AutoSize = this.label11.AutoSize = this.label12.AutoSize =
            this.label13.AutoSize = true;

            // ================= TEXTBOX STYLE (NO LOOP) =================
            this.txtBusinessID.Font = txtFont;
            this.txtBusinessName.Font = txtFont;
            this.txtCity.Font = txtFont;
            this.txtAddress1.Font = txtFont;
            this.txtAddress2.Font = txtFont;
            this.txtPostcode.Font = txtFont;
            this.txtContactName.Font = txtFont;
            this.txtPhoneNumber.Font = txtFont;
            this.txtEmailAddress.Font = txtFont;
            this.txtAccountName.Font = txtFont;
            this.txtSortCode.Font = txtFont;
            this.txtAccountNumber.Font = txtFont;

            // ================= POSITIONS =================
            this.txtBusinessID.Location = new System.Drawing.Point(180, 20);
            this.txtBusinessName.Location = new System.Drawing.Point(180, 60);
            this.txtCity.Location = new System.Drawing.Point(180, 100);
            this.txtAddress1.Location = new System.Drawing.Point(180, 140);
            this.txtAddress2.Location = new System.Drawing.Point(180, 180);
            this.txtPostcode.Location = new System.Drawing.Point(180, 220);

            this.txtContactName.Location = new System.Drawing.Point(620, 20);
            this.txtPhoneNumber.Location = new System.Drawing.Point(620, 60);
            this.txtEmailAddress.Location = new System.Drawing.Point(620, 100);
            this.txtAccountName.Location = new System.Drawing.Point(620, 140);
            this.txtSortCode.Location = new System.Drawing.Point(620, 180);
            this.txtAccountNumber.Location = new System.Drawing.Point(620, 220);

            this.cbxRegion.Font = txtFont;
            this.cbxRegion.Items.AddRange(new object[] { "North", "South", "East", "West" });
            this.cbxRegion.Location = new System.Drawing.Point(180, 260);

            // ================= ADD CONTROLS =================
            this.pnlSelect.Controls.AddRange(new Control[]
            {
                label1, txtBusinessID,
                label2, txtBusinessName,
                label3, txtCity,
                label4, txtAddress1,
                label5, txtAddress2,
                label6, txtPostcode,
                label7, cbxRegion,
                label9, txtContactName,
                label8, txtPhoneNumber,
                label10, txtEmailAddress,
                label11, txtAccountName,
                label12, txtSortCode,
                label13, txtAccountNumber
            });

            // ================= BUTTON =================
            this.btnAddNewBusiness.BackColor = mainBlue;
            this.btnAddNewBusiness.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBusiness.FlatStyle = FlatStyle.Flat;
            this.btnAddNewBusiness.FlatAppearance.BorderSize = 0;
            this.btnAddNewBusiness.Location = new System.Drawing.Point(390, 440);
            this.btnAddNewBusiness.Size = new System.Drawing.Size(170, 45);
            this.btnAddNewBusiness.Text = "SAVE BUSINESS";
            this.btnAddNewBusiness.Click += new System.EventHandler(this.btnAddNewBusiness_Click);

            // ================= FORM =================
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 545);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAddNewBusiness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add Business";

            this.pnlHeader.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Button btnAddNewBusiness;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;

        private Label label1, label2, label3, label4, label5, label6,
                      label7, label8, label9, label10, label11, label12, label13;

        private TextBox txtBusinessName, txtCity, txtAddress1, txtAddress2,
                        txtPostcode, txtContactName, txtPhoneNumber,
                        txtEmailAddress, txtAccountName, txtSortCode,
                        txtAccountNumber, txtBusinessID;

        private ComboBox cbxRegion;
        private Panel pnlHeader;
        private Panel pnlSelect;
    }
}