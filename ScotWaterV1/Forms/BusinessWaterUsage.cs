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

        private void BusinessWaterUsage_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddUsage_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Please select a business");
                return;
            }

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            int used;
            int recycled;

            if (!int.TryParse(txt_Water_Used.Text, out used) ||
                !int.TryParse(txtRecycledWater.Text, out recycled))
            {
                MessageBox.Show("Enter valid numbers");
                return;
            }

            DateTime date = dtpDate.Value;

            using (var db = new BusinessDataContext())
            {
                WaterUsage usage = new WaterUsage
                {
                    BusinessID = businessId,
                    FreshwaterUnitsUsed = used,
                    RecycledUnits = recycled,
                    ReadingDate = date,
                    IsLowReserve = false
                };

                db.WaterUsage.Add(usage);   // ✅ correct for EF
                db.SaveChanges();           // ✅ correct for EF
            }

            MessageBox.Show("Usage saved");
           }
private void LoadUsageForBusiness()
        {
            if (CmbBusiness.SelectedValue == null)
                return;

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            using (var db = new BusinessDataContext())
            {
                dgv_Business.DataSource = db.WaterUsage
                    .Where(w => w.BusinessID == businessId)
                    .Select(w => new
                    {
                        w.ReadingDate,
                        w.FreshwaterUnitsUsed,
                        w.RecycledUnits
                    })
                    .ToList();
            }
        } 
    }
}