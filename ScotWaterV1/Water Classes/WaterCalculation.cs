using System;

namespace ScotWaterV1
{
    public class WaterCalculation
    {
        // Standard Rates
        private const decimal Std_0_40 = 0.41m;
        private const decimal Std_41_80 = 0.64m;
        private const decimal Std_81_Plus = 1.35m;

        // Low Reserve Rates
        private const decimal Low_0_40 = 0.47m;
        private const decimal Low_41_80 = 0.82m;
        private const decimal Low_81_Plus = 2.25m;

        public decimal Calculate(WaterUsage usage, WaterRecyclingDiscount discount)
        {
            decimal cost = 0;
            int units = usage.FreshwaterUnitsUsed;

            // Choose correct rate set
            decimal rate0to40 = usage.IsLowReserve ? Low_0_40 : Std_0_40;
            decimal rate41to80 = usage.IsLowReserve ? Low_41_80 : Std_41_80;
            decimal rate81plus = usage.IsLowReserve ? Low_81_Plus : Std_81_Plus;

            // Band 1: 0–40 units
            int band1 = Math.Min(units, 40);
            cost += band1 * rate0to40;

            // Band 2: 41–80 units
            if (units > 40)
            {
                int band2 = Math.Min(units - 40, 40);
                cost += band2 * rate41to80;
            }

            // Band 3: 81+ units
            if (units > 80)
            {
                int band3 = units - 80;
                cost += band3 * rate81plus;
            }

            // Apply recycling discount
            decimal discountRate = discount.GetDiscountRate(usage);

            decimal totalDiscount = usage.FreshwaterUnitsUsed * discountRate;

            usage.WaterTotalCost = cost - totalDiscount;

            return usage.WaterTotalCost;
        }
    }
}
