using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterCharges : Form
    {
        public frmChangeWaterCharges()
        {
            InitializeComponent();
        }

        // SIGN OUT
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
        // MAIN MENU
        private void btnChangeWaterCharges_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
           

            if (comboChangeCharges.Text == string.Empty || txtNewPrice.Text == string.Empty)
            {
                MessageBox.Show("Please select a charge type and enter a price.");
                return;
            }

            if (!decimal.TryParse(txtNewPrice.Text, out decimal newPrice) || newPrice < 0)
            {
                MessageBox.Show("Enter a valid price greater than or equal to 0.");
                return;
            }

            //Unit Pricing

            //Normal
            double NormalUnitPriceLow = 0.41;
            double NormalUnitPriceMedium = 0.64;
            double NormalUnitPriceHigh = 1.35;

            //Drought
            double DroughtUnitPriceLow = 0.47;
            double DroughtUnitPriceMedium = 0.82;
            double DroughtUnitPriceHigh = 2.25;

            //Recycled
            double RecycledUnitPriceLow = 0.05;
            double RecycledUnitPriceMedium = 0.15;
            double RecycledUnitPriceHigh = 0.25;



            // Normal Units
            if (comboChangeCharges.Text == "Normal 0-40 Units")
            {
                lblLowUsagePrice.Text = $"£{txtNewPrice.Text}";
                NormalUnitPriceLow = (double)newPrice;
            }
            else if (comboChangeCharges.Text == "Normal 41-80 Units")
            {
                lblMediumUsagePrice.Text = $"£{txtNewPrice.Text}";
                NormalUnitPriceMedium = (double)newPrice;
            }
            else if (comboChangeCharges.Text == "Normal 81+ Units")
            {
                lblHighUsagePrice.Text = $"£{txtNewPrice.Text}";
                NormalUnitPriceHigh = (double)newPrice;
            }

            // Drought Units
            if (comboChangeCharges.Text == "Drought 0-40 Units")
            {
                lblDroughtLowUsagePrice.Text = $"£{txtNewPrice.Text}";
                DroughtUnitPriceLow = (double)newPrice;
            }
            else if (comboChangeCharges.Text == "Drought 41-80 Units")
            {
                lblDroughtMediumUsagePrice.Text = $"£{txtNewPrice.Text}";
                DroughtUnitPriceMedium = (double)newPrice;
            }
            else if (comboChangeCharges.Text == "Drought 81+ Units")
            {
                lblDroughtHighUsagePrice.Text = $"£{txtNewPrice.Text}";
                DroughtUnitPriceHigh = (double)newPrice;
            }


            else if (comboChangeCharges.Text == "Recycled 0 - 5 Units")
            {
                lblRecycledLowDiscount.Text = $"£{newPrice}";
                RecycledUnitPriceLow = (double)newPrice;
            }
            else if (comboChangeCharges.Text == "Recycled 6-20 Units")
            {
                lblMediumRecyclePrice.Text = $"£{newPrice}";
                RecycledUnitPriceMedium = (double)newPrice;
            }
            else if (comboChangeCharges.Text == "Recycled 21+ Units")
            {
                lblHighRecyclePrice.Text = $"£{newPrice}";
                RecycledUnitPriceHigh = (double)newPrice;
            }

        }
    }
}