using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class AdminUsers
    {
        [Key]
        public int AdminUserID { get; set; }

        [Required]
        public string AdminUsername { get; set; }

        [Required]
        public string AdminPassword { get; set; }
    }
}
