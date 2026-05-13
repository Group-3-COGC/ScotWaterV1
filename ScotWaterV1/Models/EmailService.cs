using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class EmailService
    {
        public async Task SendEmail(string recipentEmail, string subject, string body)
        {
            if (string.IsNullOrWhiteSpace(recipentEmail) || !recipentEmail.Contains("@"))
                throw new ArgumentException("Invalid recipent email address.");

            using (var db = new BusinessDataContext())
            {
                var config = db.EmailConfigs.FirstOrDefault();

                if (config == null)
                    throw new InvalidOperationException("Email settings have not been configured.");

                using (MailMessage message = new MailMessage())
                using (SmtpClient smtp = new SmtpClient(config.SmtpHost, config.SmtpPort))
                {
                    message.From = new MailAddress(config.SenderEmail);
                    message.To.Add(recipentEmail);
                    message.Subject = subject;
                    message.Body = body;


                    smtp.EnableSsl = config.EnableSsl;
                    smtp.Timeout = 10000;
                    smtp.Credentials = new NetworkCredential(
                        config.SenderEmail,
                        config.SenderPassword
                    );

                    await Task.Run(() => smtp.Send(message));
                       
                }
            }
        }
    }
}

