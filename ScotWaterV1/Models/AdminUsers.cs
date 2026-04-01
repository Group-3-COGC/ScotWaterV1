using ScotWaterV1.Models;
using ScotWaterV1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1
{
    public class AdminUsers
    {
        //Admin user class to hold the data for the admin users
        public int AdminID { get; set; }  //primary key
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

   
    }
}
