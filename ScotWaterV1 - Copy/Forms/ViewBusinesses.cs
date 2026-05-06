using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using ScotWaterV1.Forms; // Add this using directive at the top with the others

namespace ScotWaterV1.Forms
{
    public partial class ViewBusinesses : Form
    {
        private int selectedBusinessID = 0;

        public ViewBusinesses()
        {
            InitializeComponent();
            LoadBusinesses();
        }

        private void ViewBusinesses_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
        }

        private void LoadBusinesses(string searchText = "")
        {
            using (var db = new BusinessDataContext())
            {
                //Get the businesses
                var businesses = db.BusinessUser.ToList();

                //get the water usages
                var waterList = db.WaterUsage.ToList();

                if (searchText != "")
                {
                    searchText = searchText.ToLower();

                    businesses = businesses
                        .Where(b => b.CompanyName.ToLower().Contains(searchText) ||
                                    b.Postcode.ToLower().Contains(searchText) ||
                                    b.ContactName.ToLower().Contains(searchText) ||
                                    b.ContactEmail.ToLower().Contains(searchText))
                        .ToList();
                }


                //create the result list
                var data = new List<BusinessView>();

                foreach (var b in businesses)
                {

                    //filter usages using Where function
                    var usage = waterList.Where(w => w.BusinessID == b.BusinessID).ToList();

                    //calculations
                    int todayUsage = usage
                        .Where(w =>w.ReadingDate.Date == DateTime.Today)
                        .Sum(w => w.FreshwaterUnitsUsed);

                    int monthlyUsage = usage
                        .Where(w => w.ReadingDate.Month == DateTime.Now.Month)
                        .Sum(w => w.FreshwaterUnitsUsed);

                    int recycled = usage.Sum(w => w.RecycledUnits);

                    var latest = usage
                        .OrderByDescending(w => w.ReadingDate)
                        .FirstOrDefault();

                    string status = "OK";
                    if(latest != null && latest.IsLowReserve)
                    {
                        status = "LOW";
                    }

                    //add all this data to list
                    data.Add(new BusinessView
                    {
                        BusinessID = b.BusinessID,
                        Name = b.CompanyName,
                        Postcode = b.Postcode,
                        TodayUsage = todayUsage,
                        MonthlyUsage = monthlyUsage,
                        RecycledWater = recycled,
                        Status = status
                    });

                }

                dgvBusinesses.AutoGenerateColumns = true;
                dgvBusinesses.DataSource = data;


                if (dgvBusinesses.Columns["BusinessID"] != null)
                {
                    dgvBusinesses.Columns["BusinessID"].Visible = false;
                }
            }
        }
      
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim().ToLower(); // FIXED HERE

            LoadBusinesses(search);
            
        }   

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedBusinessID == 0)
            {
                MessageBox.Show("Please select a business first before editing");
                return;
            }

            using (var db = new BusinessDataContext())
            { 
                var business = db.BusinessUser.FirstOrDefault(b => b.BusinessID == selectedBusinessID);

                if (business !=null)
                {
                    bool noChanges =
                        business.CompanyName == txtCompanyName.Text.Trim() &&
                        business.Postcode == txtPostcode.Text.Trim() &&
                        business.ContactName == txtContactName.Text.Trim() &&
                        business.ContactEmail == txtContactEmail.Text.Trim();

                    if (noChanges)
                    {
                        MessageBox.Show("No changes were made. Please make any changes before clicking edit");
                        return;
                    }

                    business.CompanyName = txtCompanyName.Text;
                    business.Postcode = txtPostcode.Text;
                    business.ContactName = txtContactName.Text; 
                    business.ContactEmail = txtContactEmail.Text;


                    db.SaveChanges();
                    MessageBox.Show("Business updated successfully");
                }
            }

            LoadBusinesses();
        }
       
        private void dgvBusinesses_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //check the collections in the rows based on what user has clicked then display on the text boxes
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBusinesses.Rows[e.RowIndex];

                selectedBusinessID = Convert.ToInt32(row.Cells["BusinessID"].Value);

                using (var db = new BusinessDataContext())
                {
                    var business = db.BusinessUser.FirstOrDefault(b => b.BusinessID == selectedBusinessID);

                    if (business != null)
                    {
                        txtCompanyName.Text = business.CompanyName;
                        txtPostcode.Text = business.Postcode;
                        txtContactName.Text = business.ContactName;
                        txtContactEmail.Text = business.ContactEmail; 
                    }
                }
               
            }
        }

        private void btnV_B_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }

    }
}