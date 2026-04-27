using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class ReserveConfig
    {
        [Key]
        public int ReserveConfigID { get; set; }

        [Required]
        public decimal CurrentReservePercentage { get; set; }
    }
}
