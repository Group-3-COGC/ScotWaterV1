using System.Linq;
using ScotWaterV1.Core;
using ScotWaterV1.Models;

namespace ScotWaterV1.Services
{
    public class AuthService
    {
        private readonly BusinessDataContext _db;

        public AuthService()
        {
            _db = new BusinessDataContext();
        }

       
        // STAFF LOGIN
       
        public bool LoginStaff(string username, string password, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please enter both username and password.";
                return false;
            }

            var staff = _db.StaffUser.FirstOrDefault(s => s.staffUsername == username);

            if (staff == null)
            {
                errorMessage = "Invalid username or password.";
                return false;
            }

            bool valid = PasswordSecurity.VerifyPassword(password, staff.staffPassword);

            if (!valid)
            {
                errorMessage = "Invalid username or password.";
                return false;
            }

            // Set session
            Session.SetStaffSession(staff.StaffUserID, staff.staffUsername);
            return true;
        }

       
        // ADMIN LOGIN
      
        public bool LoginAdmin(string username, string password, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please enter both username and password.";
                return false;
            }

            var admin = _db.AdminUsers.FirstOrDefault(a => a.AdminUsername == username);

            if (admin == null)
            {
                errorMessage = "Invalid username or password.";
                return false;
            }

            bool valid = PasswordSecurity.VerifyPassword(password, admin.AdminPassword);

            if (!valid)
            {
                errorMessage = "Invalid username or password.";
                return false;
            }

            // Set session 
            Session.SetAdminSession(admin.AdminUserID, admin.AdminUsername);

            return true;
        }

        // LOGOUT
       
        public void Logout()
        {
            Session.ClearSession(); 
        }
    }
}
