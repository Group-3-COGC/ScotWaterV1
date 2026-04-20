using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class StaffUser
    {
        [Key]
        public int StaffUserID { get; set; }
        public string staffUsername { get; set; }
        public string staffPassword { get; set; }

        public List<WaterUsage> WaterUsage { get; set; }

       
    }
}
