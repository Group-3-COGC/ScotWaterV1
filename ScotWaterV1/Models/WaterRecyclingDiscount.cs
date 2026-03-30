using System;

namespace ScotWaterV1
{
    public class WaterRecyclingDiscount
    {
        // Discount bands based on recycled units
        public decimal Discount0To5 { get; set; }
        public decimal Discount6To20 { get; set; }
        public decimal Discount21Plus { get; set; }

        // Constructor sets default discount values from the project brief
        public WaterRecyclingDiscount()
        {
            Discount0To5 = 0.05m;
            Discount6To20 = 0.15m;
            Discount21Plus = 0.25m;
        }

        // Returns the correct discount rate based on recycled units
        public decimal GetDiscountRate(int recycledUnits)
        {
            if (recycledUnits <= 5)
                return Discount0To5;

            if (recycledUnits <= 20)
                return Discount6To20;

            return Discount21Plus;
        }
    }
}
