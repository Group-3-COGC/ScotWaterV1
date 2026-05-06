namespace ScotWaterV1
{
    public static class Session
    {
        public static int AdminUserID { get; private set; }
        public static string AdminUsername { get; private set; }
        public static bool IsAdminLoggedIn { get; private set; }

        public static int StaffUserID { get; private set; }
        public static string StaffUsername { get; private set; }
        public static bool IsStaffLoggedIn { get; private set; }

        public static void SetAdminSession(int id, string username)
        {
            AdminUserID = id;
            AdminUsername = username;
            IsAdminLoggedIn = true;
        }

        public static void SetStaffSession(int id, string username)
        {
            StaffUserID = id;
            StaffUsername = username;
            IsStaffLoggedIn = true;
        }

        public static void ClearSession()
        {
            AdminUserID = 0;
            AdminUsername = null;
            IsAdminLoggedIn = false;

            StaffUserID = 0;
            StaffUsername = null;
            IsStaffLoggedIn = false;
        }
    }
}
