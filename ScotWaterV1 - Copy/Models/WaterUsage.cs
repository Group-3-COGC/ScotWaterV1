using System;
using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class WaterUsage
    {
        [Key]
        public int WaterUsageID { get; set; }

        [Required]
        public int FreshwaterUnitsUsed { get; set; }

        [Required]
        public int RecycledUnits { get; set; }

        [Required]
        public DateTime ReadingDate { get; set; }

        [Required]
        public int BusinessID { get; set; }

        [Required]
        public int StaffUserID { get; set; }

        public bool IsLowReserve { get; set; }

        public BusinessUser BusinessUser { get; set; }
        public StaffUser StaffUser { get; set; }
    }
}
