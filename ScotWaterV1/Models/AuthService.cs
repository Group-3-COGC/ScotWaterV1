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

                // ================= LOCK CHECK =================
                if (user.LockUntil != null && user.LockUntil > DateTime.Now)
                {
                    TimeSpan remaining = user.LockUntil.Value - DateTime.Now;
                    error = $"Account locked. Try again in {remaining.Minutes}m {remaining.Seconds}s";
                    return false;
                }

                // reset lock if expired
                if (user.LockUntil != null && user.LockUntil <= DateTime.Now)
                {
                    user.LockUntil = null;
                    user.FailedLoginAttempts = 0;
                }

                // ================= PASSWORD CHECK =================
                if (!PasswordSecurity.VerifyPassword(password, user.staffPassword))
                {
                    user.FailedLoginAttempts++;

                    if (user.FailedLoginAttempts >= 3)
                    {
                        int minutes = Math.Max(1, user.FailedLoginAttempts - 2);

                        user.LockUntil = DateTime.Now.AddMinutes(minutes);
                        error = $"Too many attempts. Locked for {minutes} minute(s).";
                        user.FailedLoginAttempts = 0;
                    }
                    else
                    {
                        error = $"Incorrect password ({user.FailedLoginAttempts}/3)";
                    }

                    db.SaveChanges();
                    return false;
                }

                // ================= SUCCESS =================
                user.FailedLoginAttempts = 0;
                user.LockUntil = null;

                db.SaveChanges();
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

                // ================= LOCK CHECK =================
                if (user.LockUntil != null && user.LockUntil > DateTime.Now)
                {
                    TimeSpan remaining = user.LockUntil.Value - DateTime.Now;
                    error = $"Account locked. Try again in {remaining.Minutes}m {remaining.Seconds}s";
                    return false;
                }

                if (user.LockUntil != null && user.LockUntil <= DateTime.Now)
                {
                    user.LockUntil = null;
                    user.FailedLoginAttempts = 0;
                }

                // ================= PASSWORD CHECK =================
                if (!PasswordSecurity.VerifyPassword(password, user.AdminPassword))
                {
                    user.FailedLoginAttempts++;

                    if (user.FailedLoginAttempts >= 3)
                    {
                        int minutes = Math.Max(1, user.FailedLoginAttempts - 2);

                        user.LockUntil = DateTime.Now.AddMinutes(minutes);
                        error = $"Too many attempts. Locked for {minutes} minute(s).";
                        user.FailedLoginAttempts = 0;
                    }
                    else
                    {
                        error = $"Incorrect password ({user.FailedLoginAttempts}/3)";
                    }

                    db.SaveChanges();
                    return false;
                }

                // ================= SUCCESS =================
                user.FailedLoginAttempts = 0;
                user.LockUntil = null;

                db.SaveChanges();
                return true;
            }
        }
    }
    }

