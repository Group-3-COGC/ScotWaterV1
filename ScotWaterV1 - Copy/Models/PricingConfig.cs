using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class PricingConfig
    {
        [Key]
        public int PricingConfigID { get; set; }

        [Required]
        public decimal FreshwaterPricePerUnit { get; set; }

        [Required]
        public decimal RecycledPricePerUnit { get; set; }

        [Required]
        public decimal LowReserveMultiplier { get; set; }

        [Required]
        public decimal DiscountRate { get; set; }

        [Required]
        public decimal VATRate { get; set; }
    }
}
