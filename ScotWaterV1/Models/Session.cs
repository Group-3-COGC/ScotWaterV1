using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Core
{
    public static class Session
    {
        // Staff session
        public static int StaffUserID { get; private set; }
        public static string StaffUsername { get; private set; }

        // Admin session
        public static int AdminUserID { get; private set; }
        public static string AdminUsername { get; private set; }

        // Login methods
        public static void SetStaffSession(int id, string username)
        {
            StaffUserID = id;
            StaffUsername = username;
            AdminUserID = 0;
            AdminUsername = null;
        }

        public static void SetAdminSession(int id, string username)
        {
            AdminUserID = id;
            AdminUsername = username;
            StaffUserID = 0;
            StaffUsername = null;
        }

        // Logout
        public static void Clear()
        {
            StaffUserID = 0;
            StaffUsername = null;
            AdminUserID = 0;
            AdminUsername = null;
        }

        // Helpers
        public static bool IsStaffLoggedIn => StaffUserID > 0;
        public static bool IsAdminLoggedIn => AdminUserID > 0;
        public static bool IsLoggedIn => IsStaffLoggedIn || IsAdminLoggedIn;
    }
}
