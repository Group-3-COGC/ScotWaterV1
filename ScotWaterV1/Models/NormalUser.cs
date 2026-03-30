using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1
{
    public class NormalUser
    {
        //get; set; attributes for normal users
        public string CustomerID { get; set; }  //primary key
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string ContactName { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string AccountName { get; set; }


    }
}
