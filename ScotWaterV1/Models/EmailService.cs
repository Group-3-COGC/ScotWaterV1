using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ScotWaterV1.Models
{
    public class EmailService
    {
        public async Task SendEmailAsync(string recipentEmail, string subject, string body)
        {
            if (string.IsNullOrWhiteSpace(recipentEmail) || !recipentEmail.Contains("@"))
                throw new ArgumentException("Invalid recipent email address.");

            using (var db = new BusinessDataContext())
            {
                var config = db.EmailConfigs.FirstOrDefault();

                if (config == null)
                    throw new InvalidOperationException("Email settings have not been configured.");

                try
                {
                    using (MailMessage message = new MailMessage())
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        // ================= SMTP SETTINGS (OUTLOOK FIX) =================
                        smtp.Host = config.SmtpHost;
                        smtp.Port = config.SmtpPort;
                        smtp.EnableSsl = config.EnableSsl;
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        smtp.Credentials = new NetworkCredential(
                            config.SenderEmail,
                            config.SenderPassword
                        );

                        smtp.Timeout = 10000; // prevents infinite hanging

                        // ================= EMAIL =================
                        message.From = new MailAddress(config.SenderEmail);
                        message.To.Add(recipentEmail);
                        message.Subject = subject;
                        message.Body = body;

                        await smtp.SendMailAsync(message).ConfigureAwait(false);
                    }
                }
                catch (SmtpException ex)
                {
                    throw new Exception("SMTP failed: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Email error: " + ex.Message);
                }
            }
        }
    }
}