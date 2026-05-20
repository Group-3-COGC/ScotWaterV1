using ScotWaterV1.Core;
using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class AddNewStaffMember : Form
    {
        private readonly BusinessDataContext _context = new BusinessDataContext();

        public AddNewStaffMember()
        {
            InitializeComponent();
            LoadUsers();
        }

        // ================= LOAD STAFF + ADMINS =================
        private void LoadUsers()
        {
            var staff = _context.StaffUser
                .Select(s => new
                {
                    Type = "Staff",
                    ID = s.StaffUserID,
                    Username = s.staffUsername,
                    Email = s.staffEmail
                })
                .ToList();   // IMPORTANT FIX

            var admins = _context.AdminUsers
                .Select(a => new
                {
                    Type = "Admin",
                    ID = a.AdminUserID,
                    Username = a.AdminUsername,
                    Email = a.AdminEmail
                })
                .ToList();   // IMPORTANT FIX

            var combined = staff.Concat(admins).ToList();

            dgvBusinesses.DataSource = combined;
        }

        // ================= ADD NEW STAFF =================
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

            if (_context.StaffUser.Any(s => s.staffUsername == username))
            {
                MessageBox.Show("This username already exists.");
                return;
            }

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

            LoadUsers();
        }

        // ================= SELECT USER FROM GRID =================
        private void dgvBusinesses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvBusinesses.Rows[e.RowIndex];

            txtContactName.Text = row.Cells["Username"].Value?.ToString();
            txtContactEmail.Text = row.Cells["Email"].Value?.ToString();
        }

        // ================= SAVE EMAIL UPDATE =================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = txtContactName.Text.Trim();
            string email = txtContactEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            // STAFF UPDATE
            var staff = _context.StaffUser
                .FirstOrDefault(s => s.staffUsername == username);

            if (staff != null)
            {
                staff.staffEmail = email;
            }
            else
            {
                // ADMIN UPDATE
                var admin = _context.AdminUsers
                    .FirstOrDefault(a => a.AdminUsername == username);

                if (admin != null)
                {
                    admin.AdminEmail = email;
                }
                else
                {
                    MessageBox.Show("User not found.");
                    return;
                }
            }

            _context.SaveChanges();

            MessageBox.Show("Email updated successfully!");

            LoadUsers();
        }
    }
}