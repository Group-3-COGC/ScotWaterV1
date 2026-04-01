using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScotWaterV1.Models;

namespace ScotWaterV1
{
    public class WaterUsage
    {
        [Key]
        public int FreshwaterUnitsUsed { get; set; } //primary Key

      
        // True = Low Reserve, False = Standard
        public bool IsLowReserve { get; set; }

        public int RecycledUnits { get; set; }

        public decimal WaterTotalCost { get; set; }

        //Water recyling discount
        public decimal Discount0To5 { get; set; }
        public decimal Discount6To20 { get; set; }
        public decimal Discount21Plus { get; set; }


        //Navigational properties
        [ForeignKey("BusinessUser")]

        public int CustomerID { get; set; }

        public BusinessUser BusinessUser { get; set; }

        [ForeignKey("StaffUser")]

        public int UserID { get; set; }

        public StaffUser StaffUser { get; set; }

    }
}
