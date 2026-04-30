using System;

namespace ScotWaterV1.Models
{
    public class BillingService
    {
        private const decimal VAT_RATE = 0.20m;

        public BusinessBills GenerateBill(WaterUsage usage)
        {
            if (usage == null)
                throw new ArgumentNullException(nameof(usage));

            int freshwater = usage.FreshwaterUnitsUsed;
            int recycled = usage.RecycledUnits;

            if (freshwater < 0)
                throw new ArgumentException("Freshwater units cannot be negative.");

            if (recycled < 0)
                throw new ArgumentException("Recycled units cannot be negative.");

            decimal totalCharges = CalculateWaterCharge(freshwater, usage.IsLowReserve);
            decimal discountRate = GetRecyclingDiscountRate(recycled);
            decimal totalDiscount = freshwater * discountRate;

            decimal subTotal = totalCharges - totalDiscount;
            if (subTotal < 0) subTotal = 0;

            decimal vat = subTotal * VAT_RATE;
            decimal finalCost = subTotal + vat;

            return new BusinessBills
            {
                BusinessID = usage.BusinessID,
                BillDate = usage.ReadingDate.Date,
                TotalCharges = Math.Round(totalCharges, 2),
                TotalDiscount = Math.Round(totalDiscount, 2),
                DiscountRate = discountRate,
                SubTotal = Math.Round(subTotal, 2),
                VAT = Math.Round(vat, 2),
                BusinessFinalCost = Math.Round(finalCost, 2)
            };
        }

        private decimal CalculateWaterCharge(int units, bool isLowReserve)
        {
            decimal firstRate = isLowReserve ? 0.47m : 0.41m;
            decimal secondRate = isLowReserve ? 0.82m : 0.64m;
            decimal thirdRate = isLowReserve ? 2.25m : 1.35m;

            decimal total = 0;

            int firstBand = Math.Min(units, 40);
            total += firstBand * firstRate;

            if (units > 40)
            {
                int secondBand = Math.Min(units - 40, 40);
                total += secondBand * secondRate;
            }

            if (units > 80)
            {
                int thirdBand = units - 80;
                total += thirdBand * thirdRate;
            }

            return total;
        }

        private decimal GetRecyclingDiscountRate(int recycledUnits)
        {
            if (recycledUnits <= 5)
                return 0.05m;

            if (recycledUnits <= 20)
                return 0.15m;

            return 0.25m;
        }
    }
}
