using ScotWaterV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmAddBusiness : Form
    {
        
        private readonly BusinessDataContext _context = new BusinessDataContext();
        public frmAddBusiness()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewBusiness_Click(object sender, EventArgs e)
        {
            try
            {
                //validate new entered info

                if (string.IsNullOrWhiteSpace(txtBusinessName.Text))
                {
                    MessageBox.Show("Business name is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress1.Text))
                {
                    MessageBox.Show("Address is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCity.Text))
                {
                    MessageBox.Show("City/Location is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPostcode.Text))
                {
                    MessageBox.Show("Postcode is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbxRegion.Text))
                {
                    MessageBox.Show("Region is required.");
                    return;
                }
                //CHECK also for "@" in email
                if (string.IsNullOrWhiteSpace(txtEmailAddress.Text) || !txtEmailAddress.Text.Contains("@"))
                {
                    MessageBox.Show("Email is required and must contain @.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Phone number is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmailAddress.Text) || !txtEmailAddress.Text.Contains("."))
                {
                    MessageBox.Show("Email is required and must contain '.'");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtContactName.Text))
                {
                    MessageBox.Show("Contact Name is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAccountName.Text))
                {
                    MessageBox.Show("Account Name is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSortCode.Text))
                {
                    MessageBox.Show("Sort Code is required.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
                {
                    MessageBox.Show("Account Number is required.");
                    return;
                }
                string postcode = txtPostcode.Text.Trim();
                string cleaned = postcode.Replace(" ", "");

                //only allow for 5 to 8 characters and only allow letters and digits
                if (cleaned.Length < 5 || cleaned.Length > 8 || !cleaned.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("Postcode must be 5 to 8 characters long and contain only letters or numbers.");
                    return;
                }
                string sortCode = txtSortCode.Text.Trim();

                // Remove spaces if you want to allow "12 34 56"
                string clean = sortCode.Replace(" ", "");

                if (clean.Length != 6 || !clean.All(char.IsDigit))
                {
                    MessageBox.Show("Sort code must be exactly 6 digits.");
                    return;
                }

                string accountNumber = txtAccountNumber.Text.Trim();

               
                cleaned = accountNumber.Replace(" ", "");

                if (cleaned.Length != 8 || !cleaned.All(char.IsDigit))
                {
                    MessageBox.Show("Account number must be exactly 8 digits.");
                    return;
                }



                //load the entered data into the Business user table
                var newBusiness = new BusinessUser
                {
                    CompanyName = txtBusinessName.Text,
                    Address1 = txtAddress1.Text,
                    Address2 = txtAddress2.Text,
                    City = txtCity.Text,
                    Postcode = txtPostcode.Text,
                    Region = cbxRegion.Text,
                    ContactName = txtContactName.Text,
                    ContactEmail = txtEmailAddress.Text,
                    ContactNumber = txtPhoneNumber.Text,
                    AccountName = txtAccountName.Text,
                    SortCode = txtSortCode.Text,
                    AccountNumber = txtAccountNumber.Text
                };
                //check if business already exists and not allow of duplicate businesses to be entered
                bool businessExits = _context.BusinessUser.Any(b =>
                b.CompanyName == txtBusinessName.Text.Trim() &&
                b.Postcode == txtPostcode.Text.Trim());

                _context.BusinessUser.Add(newBusiness);
                _context.SaveChanges();

                MessageBox.Show("Business saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
            }
            //throw exception if there is an error saving changes
            catch (Exception ex)
            {
                MessageBox.Show("Error saving business: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //clear text box fields if clicked
        private void ClearFields()
        {
            txtBusinessName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtPostcode.Clear();
            cbxRegion.SelectedIndex = -1;
            txtContactName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtAccountName.Clear();
            txtSortCode.Clear();
            txtAccountNumber.Clear();
        }
    }
}
    

