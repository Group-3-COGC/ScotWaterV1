using System;

namespace ScotWaterV1.Models
{
    public class StaffUser
    {
        public int StaffUserID { get; set; }

        public string staffUsername { get; set; }
        public string staffPassword { get; set; }

        public string staffEmail { get; set; }
        public string ResetCode { get; set; }

        public int FailedLoginAttempts { get; set; }
        public DateTime? LockUntil { get; set; }

        public int LockLevel { get; set; }   
    }
}