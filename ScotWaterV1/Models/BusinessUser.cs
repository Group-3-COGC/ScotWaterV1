using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class BusinessUser
    {
        [Key]
        //get; set; attributes for normal users
        public int BusinessID { get; set; } //primary key
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string AccountName { get; set; }

        //navigational properties
        public List<WaterUsage> WaterUsage { get; set; }
        public List<BusinessBills> BusinessBills { get; set; }
    }
}
