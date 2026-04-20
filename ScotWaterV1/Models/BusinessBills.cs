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
        public int BusinessBillID { get; set; } //primary key
        public DateTime BillDate { get; set; } 
        public decimal TotalCharges { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal VAT { get; set; }
        public decimal BusinessFinalCost { get; set; }

        //navigational properties
        [ForeignKey("BusinessUser")]

        public int BusinessID { get; set; }

        public BusinessUser BusinessUser { get; set; }
    }
}
