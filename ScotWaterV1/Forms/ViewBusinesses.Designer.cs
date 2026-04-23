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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinesses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusinesses
            // 
            this.dgvBusinesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinesses.Location = new System.Drawing.Point(20, 180);
            this.dgvBusinesses.Name = "dgvBusinesses";
            this.dgvBusinesses.ReadOnly = true;
            this.dgvBusinesses.RowHeadersWidth = 51;
            this.dgvBusinesses.Size = new System.Drawing.Size(709, 350);
            this.dgvBusinesses.TabIndex = 0;
            this.dgvBusinesses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusinesses_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(20, 130);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(200, 20);
            this.txt_search.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(240, 125);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 30);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btn_Add_business
            // 
            this.btn_Add_business.Location = new System.Drawing.Point(20, 560);
            this.btn_Add_business.Name = "btn_Add_business";
            this.btn_Add_business.Size = new System.Drawing.Size(150, 35);
            this.btn_Add_business.TabIndex = 3;
            this.btn_Add_business.Text = "Add Business";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(796, 297);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnV_B_MainMenu
            // 
            this.btnV_B_MainMenu.Location = new System.Drawing.Point(209, 560);
            this.btnV_B_MainMenu.Name = "btnV_B_MainMenu";
            this.btnV_B_MainMenu.Size = new System.Drawing.Size(120, 35);
            this.btnV_B_MainMenu.TabIndex = 5;
            this.btnV_B_MainMenu.Text = "Main Menu";
            this.btnV_B_MainMenu.Click += new System.EventHandler(this.btnV_B_MainMenu_Click);
            // 
            // btnViewBusiness_SignOut
            // 
            this.btnViewBusiness_SignOut.Location = new System.Drawing.Point(720, 20);
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
            this.txtCompanyName.Location = new System.Drawing.Point(1012, 222);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(141, 20);
            this.txtCompanyName.TabIndex = 8;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(1012, 274);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(141, 20);
            this.txtPostcode.TabIndex = 9;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(1012, 332);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(141, 20);
            this.txtContactName.TabIndex = 10;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(1012, 399);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(141, 20);
            this.txtContactEmail.TabIndex = 11;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(926, 152);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEdit.Size = new System.Drawing.Size(107, 13);
            this.lblEdit.TabIndex = 12;
            this.lblEdit.Text = "Edit Businesses Here";
            // 
            // ViewBusinesses
            // 
            this.ClientSize = new System.Drawing.Size(1192, 650);
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
    }
}