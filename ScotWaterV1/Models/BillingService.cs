using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
        public class BillingService
        {
            private const decimal VAT_RATE = 0.20m;

            public BusinessBills GenerateBill(WaterUsage usage)
            {
                if (usage == null)
                    throw new ArgumentNullException(nameof(usage));

                if (usage.FreshwaterUnitsUsed < 0)
                    throw new ArgumentException("Freshwater units cannot be negative.");

                if (usage.RecycledUnits < 0)
                    throw new ArgumentException("Recycled units cannot be negative.");

                decimal totalCharges = CalculateWaterCharge(
                    usage.FreshwaterUnitsUsed,
                    usage.IsLowReserve
                );

                decimal discountRate = GetRecyclingDiscountRate(usage.RecycledUnits);
                decimal totalDiscount = usage.FreshwaterUnitsUsed * discountRate;

                decimal subTotal = totalCharges - totalDiscount;

                if (subTotal < 0)
                    subTotal = 0;

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
                if (recycledUnits >= 21)
                    return 0.25m;

                if (recycledUnits >= 6)
                    return 0.15m;

                if (recycledUnits >= 0)
                    return 0.05m;

                return 0m;
            }
        }
}

