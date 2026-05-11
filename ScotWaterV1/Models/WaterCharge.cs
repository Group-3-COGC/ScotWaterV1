namespace ScotWaterV1.Models
{
    public class WaterCharge
    {
        public int Id { get; set; }

        // Standard / Reserve / Recycle
        public string Category { get; set; }

        // Low / Medium / High
        public string Tier { get; set; }

        public decimal Price { get; set; }
    }
}