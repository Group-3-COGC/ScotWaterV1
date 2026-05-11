using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class EmailService
    {
        public void SendEmail(string recipentEmail, string subject, string body)
        {
            if (string.IsNullOrWhiteSpace(recipentEmail) || !recipentEmail.Contains("@"))
                throw new ArgumentException("Invalid recipent email address.");

            using (var db = new BusinessDataContext())
            {
                var config = db.EmailConfigs.FirstOrDefault();

                if (config == null)
                    throw new InvalidOperationException("Email settings have not been configured.");

                using (MailMessage message = new MailMessage())
                using (SmtpClient client = new SmtpClient(config.SmtpHost, config.SmtpPort))
                {
                    message.Fromv = new MailAddress(config.SenderEmail);
                    message.To.Ass(recipentEmail);
                }
            }
        }
    }
}
