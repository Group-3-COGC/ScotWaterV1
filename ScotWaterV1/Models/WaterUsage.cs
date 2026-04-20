using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScotWaterV1.Models;

namespace ScotWaterV1
{
    public class WaterUsage
    {
        [Key]
        public int WaterUsageID { get; set; } //primary Key

        public int FreshwaterUnitsUsed { get; set; } 
        
        public bool IsLowReserve { get; set; }

        public int RecycledUnits { get; set; }

        public DateTime ReadingDate { get; set; }

     

        //Navigational properties
        [ForeignKey("BusinessUser")]

        public int BusinessID { get; set; }

        public BusinessUser BusinessUser { get; set; }

        [ForeignKey("StaffUser")]

        public int StaffUserID { get; set; }

        public StaffUser StaffUser { get; set; }

    }
}
