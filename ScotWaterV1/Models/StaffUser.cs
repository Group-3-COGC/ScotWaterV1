using ScotWaterV1.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class StaffUser
{
    //Dean Caldwell
    [Key]
    public int StaffUserID { get; set; }

    [Required]
    public string staffUsername { get; set; }

    [Required]
    public string staffPassword { get; set; }

    public List<WaterUsage> WaterUsage { get; set; }

    // NEW FIELDS FOR PROPER ACCOUNT LOCKOUT
    public int FailedLoginAttempts { get; set; } = 0;
    public bool IsLocked { get; set; } = false;
}
