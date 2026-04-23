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
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
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
            BusinessBills bills = new BusinessBills();

            //Input Validation for changing the water prices
            if (comboChangeCharges.Text == string.Empty && txtNewPrice.Text == string.Empty)
            {
                MessageBox.Show("Please select and fill the input box to change price.");
            }
            else if (comboChangeCharges.Text == string.Empty || txtNewPrice.Text == string.Empty)
            {
                MessageBox.Show("Please select and fill the input box to change price.");
            }

            //Unit Pricing

            //Normal
            double NormalUnitPriceLow = 0.41;
            double NormalUnitPriceMedium = 0.64;
            double NormalUnitPriceHigh = 1.35;

            //Drought
            double DroughtUnitPriceLow = 0.47;
            double DroughtUnitPriceMedium = 0.82;
            double DroughtUnitPriceHigh = 1.35;

            //Recycled
            double RecycledUnitPriceLow = 0.05;
            double RecycledUnitPriceMedium = 0.15;
            double RecycledUnitPriceHigh = 0.25;



            // Normal Units
            if (comboChangeCharges.Text == "Normal 0-40 Units")
            {
                lblLowUsagePrice.Text = $"£{txtNewPrice}";
                NormalUnitPriceLow = Double.Parse(txtNewPrice.Text);
            }
            else if (comboChangeCharges.Text == "Normal 41-80 Units")
            {
                lblMediumUsagePrice.Text = $"£{txtNewPrice}";
                NormalUnitPriceMedium = Double.Parse(txtNewPrice.Text);
            }
            else if (comboChangeCharges.Text == "Normal 81+ Units")
            {
                lblHighUsagePrice.Text = $"£{txtNewPrice}";
                NormalUnitPriceHigh = Double.Parse(txtNewPrice.Text);
            }

            // Drought Units
            if (comboChangeCharges.Text == "Drought 0-40 Units")
            {
                lblDroughtLowUsagePrice.Text = $"£{txtNewPrice}";
                DroughtUnitPriceLow = Double.Parse(txtNewPrice.Text);
            }
            else if (comboChangeCharges.Text == "Drought 41-80 Units")
            {
                lblDroughtMediumUsagePrice.Text = $"£{txtNewPrice}";
                DroughtUnitPriceMedium = Double.Parse(txtNewPrice.Text);
            }
            else if (comboChangeCharges.Text == "Drought 81+ Units")
            {
                lblDroughtHighUsagePrice.Text = $"£{txtNewPrice}";
                DroughtUnitPriceHigh = Double.Parse(txtNewPrice.Text);
            }

            // Recycled Units
            if (comboChangeCharges.Text == "Recycled 0-5 Units")
            {
                lblRecycleLowDiscountPrice.Text = $"£{txtNewPrice}";
                RecycledUnitPriceLow = Double.Parse(txtNewPrice.Text);
            }
            else if (comboChangeCharges.Text == "Recycled 6-20 Units")
            {
                lblRecycleLowDiscountPrice.Text = $"£{txtNewPrice}";
                RecycledUnitPriceMedium = Double.Parse(txtNewPrice.Text);
            }
            else if (comboChangeCharges.Text == "Recycled 21+ Units")
            {
                lblRecycleLowDiscountPrice.Text = $"£{txtNewPrice}";
                RecycledUnitPriceHigh = Double.Parse(txtNewPrice.Text);
            }

        }
    }
}