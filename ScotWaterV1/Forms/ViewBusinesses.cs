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
           
        }

        private void ViewBusinesses_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
        }




        // =========================
        // LOAD DATA INTO GRID
        // =========================
        private void LoadBusinesses()
        {
            using (var db = new BusinessDataContext())
            {
                //Get the businesses
                var businesses = db.BusinessUser.ToList();

                //get the water usages
                var waterList = db.WaterUsage.ToList();

                //create the result list
                var data = new List<BusinessView>();

                foreach (var b in businesses)
                {

                    //filter usages using Where function
                    var usage = waterList.Where(w => w.BusinessID == b.BusinessID).ToList();

                    //calculations
                    int todayUsage = usage
                        .Where(w =>w.ReadingDate == DateTime.Today)
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

              
                dgvBusinesses.DataSource = data;
                dgvBusinesses.Columns["BusinessID"].Visible = false;
            }
        }
       

        // =========================
        // SEARCH BUTTON
        // =========================
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim().ToLower(); // FIXED HERE

            if (search == "")
            {
                LoadBusinesses();
                return;
            }

            //query the database and search for the specified business based on what user enters
            using (var db = new BusinessDataContext())
            {
                var result = db.BusinessUser
                    .Where(b =>
                        (b.CompanyName != null && b.CompanyName.ToLower().Contains(search)) ||
                        (b.Postcode != null && b.Postcode.ToLower().Contains(search)))
                    .Select(b => new
                    {
                        Name = b.CompanyName,
                        Postcode = b.Postcode,
                    })
                .ToList();

                dgvBusinesses.DataSource = result;
            }
        }

        

        private void dgvBusinesses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //check the collections in the rows based on what user has clicked then display on the text boxes
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBusinesses.Rows[e.RowIndex];

                selectedBusinessID = Convert.ToInt32(row.Cells["BusinessID"].Value);

                txtCompanyName.Text = row.Cells["Business Name"].Value.ToString();
                txtPostcode.Text = row.Cells["Postcode"].Value.ToString();
                txtContactName.Text = row.Cells["Contact Name"].Value.ToString();
                txtContactEmail.Text = row.Cells["Contact Email"].Value.ToString();
            }
        }

        private void btnV_B_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
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
    }
}