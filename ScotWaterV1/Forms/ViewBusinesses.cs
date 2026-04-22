using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScotWaterV1.Forms
{
    public partial class ViewBusinesses : Form
    {
        public ViewBusinesses()
        {
            InitializeComponent();
            this.Load += ViewBusinesses_Load;
        }

        // =========================
        // LOAD DATA INTO GRID
        // =========================
        private void LoadBusinesses()
        {
            using (var db = new BusinessDataContext())
            {
                var data = db.BusinessUser
                    .Select(b => new
                    {
                        Name = b.CompanyName,
                        Postcode = b.Postcode,

                        TodayUsage = db.WaterUsage
                            .Where(w => w.BusinessID == b.BusinessID &&
                                        w.ReadingDate == DateTime.Today)
                            .Sum(w => (int?)w.FreshwaterUnitsUsed) ?? 0,

                        MonthlyUsage = db.WaterUsage
                            .Where(w => w.BusinessID == b.BusinessID &&
                                        w.ReadingDate.Month == DateTime.Now.Month)
                            .Sum(w => (int?)w.FreshwaterUnitsUsed) ?? 0,

                        RecycledWater = db.WaterUsage
                            .Where(w => w.BusinessID == b.BusinessID)
                            .Sum(w => (int?)w.RecycledUnits) ?? 0,

                        Status = db.WaterUsage
                            .Where(w => w.BusinessID == b.BusinessID)
                            .OrderByDescending(w => w.ReadingDate)
                            .Select(w => w.IsLowReserve ? "LOW" : "OK")
                            .FirstOrDefault()
                    })
                    .ToList();

                dgvBusinesses.AutoGenerateColumns = true;
                dgvBusinesses.DataSource = data;
            }
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ViewBusinesses_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
        }

        // =========================
        // SEARCH BUTTON
        // =========================
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim().ToLower(); // FIXED HERE

            using (var db = new BusinessDataContext())
            {
                var result = db.BusinessUser
                    .Where(b =>
                        b.CompanyName.ToLower().Contains(search) ||
                        b.Postcode.ToLower().Contains(search))
                    .Select(b => new
                    {
                        Name = b.CompanyName,
                        Postcode = b.Postcode
                    })
                    .ToList();

                dgvBusinesses.DataSource = result;
            }
        }

        // =========================
        // ADD BUSINESS BUTTON
        // =========================
        private void btn_Add_business_Click(object sender, EventArgs e)
        {
            // FIX: You do NOT have Add_business form yet
            MessageBox.Show("Add Business form not created yet.");
        }

        // =========================
        // EDIT BUTTON
        // =========================
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit feature coming next");
        }

        // =========================
        // SIGN OUT
        // =========================
        private void btnViewBusiness_SignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signing out...");
            this.Close();
        }

        // =========================
        // MAIN MENU
        // =========================
       

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }

        private void dgvBusinesses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can leave this empty or add your logic here
        }
    }
}