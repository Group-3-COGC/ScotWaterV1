using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class StaffUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Navigational properties
        [ForeignKey("AdminUsers")]

        public int AdminID { get; set; }

    }
}
