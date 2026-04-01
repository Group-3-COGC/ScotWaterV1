using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1
{
    public class BusinessBills
    {
        //get; set; attributes for business bills
        public string BillingPeriod { get; set; } //primary key
        public double TotalCharges { get; set; }
        public double TotalDiscount { get; set; }
        public double DiscountRate { get; set; }
        public double SubTotal { get; set; }
        public double VAT { get; set; }
        public double BusinessFinalCost { get; set; }

    }
}
