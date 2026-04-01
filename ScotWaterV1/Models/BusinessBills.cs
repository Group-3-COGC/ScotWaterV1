using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScotWaterV1.Models;

namespace ScotWaterV1
{
    public class BusinessBills
    {
        [Key]
        //get; set; attributes for business bills
        public string BillingPeriod { get; set; } //primary key
        public double TotalCharges { get; set; }
        public double TotalDiscount { get; set; }
        public double DiscountRate { get; set; }
        public double SubTotal { get; set; }
        public double VAT { get; set; }
        public double BusinessFinalCost { get; set; }

        //navigational properties
        [ForeignKey("BusinessUser")]

        public int CustomerID { get; set; }

        public BusinessUser BusinessUser { get; set; }
    }
}
