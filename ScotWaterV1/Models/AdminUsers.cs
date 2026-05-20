using System;
using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class AdminUsers
    {
        [Key]
        public int AdminUserID { get; set; }

        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

        public string AdminEmail { get; set; }
        public string ResetCode { get; set; }

        public int FailedLoginAttempts { get; set; }
        public DateTime? LockUntil { get; set; }

        public int LockLevel { get; set; }   
    }
}