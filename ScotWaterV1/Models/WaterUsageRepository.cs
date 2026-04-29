using ScotWaterV1.Models;
using System;

namespace ScotWaterV1.Repositories
{
    public class WaterUsageRepository
    {
        public void SaveWaterUsage(int businessId, int staffUserId, int freshwater, int recycled, bool isLowReserve)
        {
            using (var context = new BusinessDataContext())
            {
                var usage = new WaterUsage()
                {
                    BusinessID = businessId,
                    StaffUserID = staffUserId,
                    FreshwaterUnitsUsed = freshwater,
                    RecycledUnits = recycled,
                    IsLowReserve = isLowReserve,
                    ReadingDate = DateTime.Now
                };

                context.WaterUsage.Add(usage);
                context.SaveChanges();
            }
        }
    }
}
