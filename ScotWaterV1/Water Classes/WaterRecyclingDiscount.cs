using System;

namespace ScotWaterV1
{
    public class WaterRecyclingDiscount
    {
        public decimal GetDiscountRate(WaterUsage usage)
        {
            int recycled = usage.RecycledUnits;

            if (recycled <= 0)
                return 0m;

            if (recycled <= 5)
                return usage.Discount0To5;

            if (recycled <= 20)
                return usage.Discount6To20;

            return usage.Discount21Plus;
        }
    }
}
