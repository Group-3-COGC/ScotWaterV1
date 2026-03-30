using System;

namespace ScotWaterV1
{
    public class WaterUsage
    {
        public int FreshwaterUnitsUsed { get; set; }

        // True = Low Reserve, False = Standard
        public bool IsLowReserve { get; set; }

        public int RecycledUnits { get; set; }

        public decimal WaterTotalCost { get; set; }

        //Water recyling discount
        public decimal Discount0To5 { get; set; }
        public decimal Discount6To20 { get; set; }
        public decimal Discount21Plus { get; set; }




    }
}
