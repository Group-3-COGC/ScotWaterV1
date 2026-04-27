using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class StaffUser
    {
        [Key]
        public int StaffUserID { get; set; }

        [Required]
        public string staffUsername { get; set; }

        [Required]
        public string staffPassword { get; set; }

        public List<WaterUsage> WaterUsage { get; set; }
    }
}
