using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class BusinessWaterUsage : Form
    {
        public BusinessWaterUsage()
        {
            InitializeComponent();
            LoadBusinesses();
        }

        
        // LOAD COMBOBOX ON START
        
        private void LoadBusinesses()
        {
            using (var db = new BusinessDataContext())
            {
                CmbBusiness.DataSource = db.BusinessUser.ToList();
                CmbBusiness.DisplayMember = "CompanyName";
                CmbBusiness.ValueMember = "BusinessID";
            }
        }

        
        // SHOW BUSINESS IN GRID
       
        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null)
                return;

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            using (var db = new BusinessDataContext())
            {
                var data = db.BusinessUser
                    .Where(b => b.BusinessID == businessId)
                    .Select(b => new
                    {
                        Name = b.CompanyName,
                        Postcode = b.Postcode
                    })
                    .ToList();

                dgv_Business.DataSource = data;
            }
        }

        
        // SIGN OUT
        
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Sign out and return to welcome screen?",
                "Confirm Signout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
        // COMBOBOX EVENT (NOT NEEDED FOR LOADING)
        
        private void CmbBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Leave empty or remove event entirely
        }
    }
}