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
                var businesses = db.BusinessBills.ToList();

                //get the water usages
                var waterList = db.WaterUsage.ToList();

                //create the result list
                var data = new List<object>();

                foreach (var b in businesses)
                {

                    //filter usages using Where function
                    var usage = waterList.Where(w => w.BusinessID == b.BusinessID).ToList();

                    //calculations


                }
            }
        }

        // =========================
        // FORM LOAD
        // =========================
       

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