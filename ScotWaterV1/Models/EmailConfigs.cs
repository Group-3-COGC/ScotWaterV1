using System;
using System.ComponentModel.DataAnnotations;

namespace ScotWaterV1.Models
{
    public class EmailConfigs
    {
        [Key]
        public int EmailSettingsID { get; set; }

        [Required]
        public string SenderEmail { get; set; } = "";

        [Required]
        public string SenderPassword { get; set; } = "";

        [Required]
        public string SmtpHost { get; set; } = "";

        [Required]
        public int SmtpPort { get; set; }

        public bool EnableSsl { get; set; } = true;
    }
}