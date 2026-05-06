using ScotWaterV1.Core;
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
    public partial class AddNewStaffMember : Form
    {
        private readonly BusinessDataContext _context = new BusinessDataContext();

        public AddNewStaffMember()
        {
            InitializeComponent();
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            // Check if username already exists
            if (_context.StaffUser.Any(s => s.staffUsername == username))
            {
                MessageBox.Show("This username already exists.");
                return;
            }

            // Hash the password using your PBKDF2 security class
            string hashedPassword = PasswordSecurity.HashPassword(password);

            var newStaff = new StaffUser
            {
                staffUsername = username,
                staffPassword = hashedPassword
            };

            _context.StaffUser.Add(newStaff);
            _context.SaveChanges();

            MessageBox.Show("Staff member added successfully!");

            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
