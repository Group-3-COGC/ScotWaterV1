using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class BusinessView
    {
        public string Name { get; set; }
        public string Postcode { get; set; }
        public int TodayUsage { get; set; }
        public int MonthlyUsage { get; set; }
        public int RecycledWater { get; set; }
        public string Status { get; set; }
    }
}
