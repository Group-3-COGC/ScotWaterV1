using ScotWaterV1.Core;
using ScotWaterV1.Models;
using System.Linq;

namespace ScotWaterV1.Services
{
    public class AuthService
    {
        // ============================
        // STAFF LOGIN
        // ============================
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

                // Check if locked
                if (user.IsLocked)
                {
                    error = "Your account is locked due to too many failed login attempts.";
                    return false;
                }

                // Check password
                if (!PasswordSecurity.VerifyPassword(password, user.staffPassword))
                {
                    user.FailedLoginAttempts++;

                    if (user.FailedLoginAttempts >= 5)
                    {
                        user.IsLocked = true;
                        error = "Your account has been locked after 5 failed attempts.";
                    }
                    else
                    {
                        int remaining = 5 - user.FailedLoginAttempts;
                        error = $"Invalid password. {remaining} attempts remaining.";
                    }

                    db.SaveChanges();
                    return false;
                }

                // Successful login → reset attempts
                user.FailedLoginAttempts = 0;
                db.SaveChanges();
                return true;
            }
        }

        // ============================
        // ADMIN LOGIN
        // ============================
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

                // Check if locked
                if (user.IsLocked)
                {
                    error = "Your account is locked due to too many failed login attempts.";
                    return false;
                }

                // Check password
                if (!PasswordSecurity.VerifyPassword(password, user.AdminPassword))
                {
                    user.FailedLoginAttempts++;

                    if (user.FailedLoginAttempts >= 5)
                    {
                        user.IsLocked = true;
                        error = "Your account has been locked after 5 failed attempts.";
                    }
                    else
                    {
                        int remaining = 5 - user.FailedLoginAttempts;
                        error = $"Invalid password. {remaining} attempts remaining.";
                    }

                    db.SaveChanges();
                    return false;
                }

                // Successful login → reset attempts
                user.FailedLoginAttempts = 0;
                db.SaveChanges();
                return true;
            }
        }

        // ============================
        // UNLOCK ACCOUNT (Admin Only)
        // ============================
        public bool UnlockUser(string username)
        {
            using (var db = new BusinessDataContext())
            {
                var staff = db.StaffUser.FirstOrDefault(u => u.staffUsername == username);
                var admin = db.AdminUsers.FirstOrDefault(a => a.AdminUsername == username);

                var user = (object)staff ?? admin;

                if (user == null)
                    return false;

                if (staff != null)
                {
                    staff.IsLocked = false;
                    staff.FailedLoginAttempts = 0;
                }

                if (admin != null)
                {
                    admin.IsLocked = false;
                    admin.FailedLoginAttempts = 0;
                }

                db.SaveChanges();
                return true;
            }
        }
    }
}
