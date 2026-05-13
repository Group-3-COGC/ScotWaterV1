using ScotWaterV1.Core;
using ScotWaterV1.Models;
using System;
using System.Linq;

namespace ScotWaterV1.Services
{
    public class AuthService
    {
        // STAFF LOGIN
        public bool LoginStaff(string username, string password, out string error)
        {
            error = "";

            using (var db = new BusinessDataContext())
            {
                
                var user = db.StaffUser.FirstOrDefault(u => u.staffUsername == username);

                if (user == null)
                {
                    error = "Incorrect username";
                    return false;
                }

                
                if (!string.Equals(user.staffUsername, username, StringComparison.Ordinal))
                {
                    error = "Incorrect username";
                    return false;
                }

                // Check password
                if (!PasswordSecurity.VerifyPassword(password, user.staffPassword))
                {
                    error = "Incorrect password";
                    return false;
                }

                return true;
            }
        }

        // ADMIN LOGIN
        public bool LoginAdmin(string username, string password, out string error)
        {
            error = "";

            using (var db = new BusinessDataContext())
            {
                var user = db.AdminUsers.FirstOrDefault(a => a.AdminUsername == username);

                if (user == null)
                {
                    error = "Incorrect username";
                    return false;
                }

               
                if (!string.Equals(user.AdminUsername, username, StringComparison.Ordinal))
                {
                    error = "Incorrect username";
                    return false;
                }

                if (!PasswordSecurity.VerifyPassword(password, user.AdminPassword))
                {
                    error = "Incorrect password";
                    return false;
                }

                return true;
            }
        }
    }
}
