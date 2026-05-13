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

  
}
