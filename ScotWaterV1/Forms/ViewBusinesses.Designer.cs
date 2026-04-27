using System;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    partial class ViewBusinesses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBusinesses));
            this.dgvBusinesses = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btn_Add_business = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnV_B_MainMenu = new System.Windows.Forms.Button();
            this.btnViewBusiness_SignOut = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusinesses
            // 
            this.dgvBusinesses.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvBusinesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinesses.Location = new System.Drawing.Point(12, 151);
            this.dgvBusinesses.Name = "dgvBusinesses";
            this.dgvBusinesses.ReadOnly = true;
            this.dgvBusinesses.RowHeadersWidth = 51;
            this.dgvBusinesses.Size = new System.Drawing.Size(632, 350);
            this.dgvBusinesses.TabIndex = 0;
            this.dgvBusinesses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusinesses_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(20, 114);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(200, 20);
            this.txt_search.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(226, 110);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 30);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btn_Add_business
            // 
            this.btn_Add_business.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_business.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add_business.Location = new System.Drawing.Point(20, 506);
            this.btn_Add_business.Name = "btn_Add_business";
            this.btn_Add_business.Size = new System.Drawing.Size(150, 35);
            this.btn_Add_business.TabIndex = 3;
            this.btn_Add_business.Text = "Add Business";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.Location = new System.Drawing.Point(838, 434);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnV_B_MainMenu
            // 
            this.btnV_B_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV_B_MainMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnV_B_MainMenu.Location = new System.Drawing.Point(199, 506);
            this.btnV_B_MainMenu.Name = "btnV_B_MainMenu";
            this.btnV_B_MainMenu.Size = new System.Drawing.Size(120, 35);
            this.btnV_B_MainMenu.TabIndex = 5;
            this.btnV_B_MainMenu.Text = "Main Menu";
            this.btnV_B_MainMenu.Click += new System.EventHandler(this.btnV_B_MainMenu_Click);
            // 
            // btnViewBusiness_SignOut
            // 
            this.btnViewBusiness_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBusiness_SignOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewBusiness_SignOut.Location = new System.Drawing.Point(360, 506);
            this.btnViewBusiness_SignOut.Name = "btnViewBusiness_SignOut";
            this.btnViewBusiness_SignOut.Size = new System.Drawing.Size(120, 35);
            this.btnViewBusiness_SignOut.TabIndex = 6;
            this.btnViewBusiness_SignOut.Text = "Sign Out";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 7;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(838, 199);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(141, 20);
            this.txtCompanyName.TabIndex = 8;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(837, 245);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(141, 20);
            this.txtPostcode.TabIndex = 9;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(837, 291);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(141, 20);
            this.txtContactName.TabIndex = 10;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(837, 337);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(141, 20);
            this.txtContactEmail.TabIndex = 11;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEdit.Location = new System.Drawing.Point(788, 151);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEdit.Size = new System.Drawing.Size(190, 24);
            this.lblEdit.TabIndex = 12;
            this.lblEdit.Text = "Edit Businesses Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1019, 104);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 547);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1025, 104);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(660, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(660, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Post Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(660, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(660, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Contact Email ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // ViewBusinesses
            // 
            this.ClientSize = new System.Drawing.Size(1015, 650);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dgvBusinesses);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.btn_Add_business);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnV_B_MainMenu);
            this.Controls.Add(this.btnViewBusiness_SignOut);
            this.Controls.Add(this.txtSearch);
            this.Name = "ViewBusinesses";
            this.Text = "View Businesses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBusinesses;
        private TextBox txt_search;
        private Button BtnSearch;
        private Button btn_Add_business;
        private Button btnEdit;
        private Button btnV_B_MainMenu;
        private Button btnViewBusiness_SignOut;
        private Label txtSearch;
        private TextBox txtCompanyName;
        private TextBox txtPostcode;
        private TextBox txtContactName;
        private TextBox txtContactEmail;
        private Label lblEdit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
    }
}