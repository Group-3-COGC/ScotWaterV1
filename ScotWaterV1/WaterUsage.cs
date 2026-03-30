using System;

namespace ScotWaterV1
{
    public class WaterUsage
    {
        public int FreshwaterUnitsUsed { get; set; }

        // True = Low Reserve, False = Standard
        public bool IsLowReserve { get; set; }

        public int RecycledUnits { get; set; }

        public double WaterTotalCost { get; set; }




    }
}
