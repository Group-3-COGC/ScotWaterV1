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
            this.button1 = new System.Windows.Forms.Button();
            this.btnV_B_MainMenu = new System.Windows.Forms.Button();
            this.btnViewBusiness_SignOut = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.Label();

            this.Business_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Today_Usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthly_Usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recycled_Water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinesses)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvBusinesses
            // 
            this.dgvBusinesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinesses.Columns.AddRange(new DataGridViewColumn[] {
                this.Business_Name,
                this.Postcode,
                this.Today_Usage,
                this.Monthly_Usage,
                this.Recycled_Water,
                this.Status
            });
            this.dgvBusinesses.Location = new System.Drawing.Point(20, 180);
            this.dgvBusinesses.Name = "dgvBusinesses";
            this.dgvBusinesses.ReadOnly = true;
            this.dgvBusinesses.Size = new System.Drawing.Size(830, 350);
            this.dgvBusinesses.TabIndex = 0;

            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(20, 130);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(200, 22);
            this.txt_search.TabIndex = 1;

            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(240, 125);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 30);
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // 
            // btn_Add_business
            // 
            this.btn_Add_business.Location = new System.Drawing.Point(20, 560);
            this.btn_Add_business.Name = "btn_Add_business";
            this.btn_Add_business.Size = new System.Drawing.Size(150, 35);
            this.btn_Add_business.Text = "Add Business";
            this.btn_Add_business.Click += new System.EventHandler(this.btn_Add_business_Click);

            // 
            // button1 (Edit)
            // 
            this.button1.Location = new System.Drawing.Point(200, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "Edit";
            this.button1.Click += new System.EventHandler(this.btn_Edit_Click);

            // 
            // btnV_B_MainMenu
            // 
            this.btnV_B_MainMenu.Location = new System.Drawing.Point(320, 560);
            this.btnV_B_MainMenu.Name = "btnV_B_MainMenu";
            this.btnV_B_MainMenu.Size = new System.Drawing.Size(120, 35);
            this.btnV_B_MainMenu.Text = "Main Menu";

            // 
            // btnViewBusiness_SignOut
            // 
            this.btnViewBusiness_SignOut.Location = new System.Drawing.Point(720, 20);
            this.btnViewBusiness_SignOut.Name = "btnViewBusiness_SignOut";
            this.btnViewBusiness_SignOut.Size = new System.Drawing.Size(120, 35);
            this.btnViewBusiness_SignOut.Text = "Sign Out";

            // 
            // Columns
            // 
            this.Business_Name.HeaderText = "Business Name";
            this.Postcode.HeaderText = "Postcode";
            this.Today_Usage.HeaderText = "Today Usage";
            this.Monthly_Usage.HeaderText = "Monthly Usage";
            this.Recycled_Water.HeaderText = "Recycled Water";
            this.Status.HeaderText = "Status";

            // 
            // ViewBusinesses
            // 
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.dgvBusinesses);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.btn_Add_business);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Button btnV_B_MainMenu;
        private Button btnViewBusiness_SignOut;
        private Label txtSearch;

        private DataGridViewTextBoxColumn Business_Name;
        private DataGridViewTextBoxColumn Postcode;
        private DataGridViewTextBoxColumn Today_Usage;
        private DataGridViewTextBoxColumn Monthly_Usage;
        private DataGridViewTextBoxColumn Recycled_Water;
        private DataGridViewTextBoxColumn Status;
    }
}