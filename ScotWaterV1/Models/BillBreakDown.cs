using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class BillBreakdownRow
    {
        public string Type { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
    }
}
