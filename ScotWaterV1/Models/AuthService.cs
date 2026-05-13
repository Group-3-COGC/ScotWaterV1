using ScotWaterV1.Core;
using ScotWaterV1.Models;
using System.Linq;

namespace ScotWaterV1.Services
{
    public class AuthService
    {
        //Dean Caldwell
        public bool LoginStaff(string username, string password, out string error)
        {
            error = "";

            using (var db = new BusinessDataContext())
            {
                var user = db.StaffUser.FirstOrDefault(u => u.staffUsername == username);

                if (user == null)
                {
                    error = "Invalid username or password.";
                    return false;
                }

                // Check password
                if (!PasswordSecurity.VerifyPassword(password, user.staffPassword))
                {
                    error = "Invalid username or password.";
                    return false;
                }

                return true;
            }
        }

       
        public bool LoginAdmin(string username, string password, out string error)
        {
            error = "";

            using (var db = new BusinessDataContext())
            {
                var user = db.AdminUsers.FirstOrDefault(a => a.AdminUsername == username);

                if (user == null)
                {
                    error = "Invalid username or password.";
                    return false;
                }

                // Check password
                if (!PasswordSecurity.VerifyPassword(password, user.AdminPassword))
                {
                    error = "Invalid username or password.";
                    return false;
                }

                return true;
            }
        }
    }
}


