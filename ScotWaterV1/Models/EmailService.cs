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
                throw new ArgumentException("Invalid recipient email address.");

            using (var db = new BusinessDataContext())
            {
                var config = db.EmailConfigs.FirstOrDefault();

                if (config == null)
                    throw new InvalidOperationException("Email settings have not been configured.");

                // ================= SAFE DEFAULTS (IMPORTANT FIX) =================
                string smtpHost = string.IsNullOrWhiteSpace(config.SmtpHost)
                    ? "smtp.office365.com"
                    : config.SmtpHost.Trim();

                int smtpPort = config.SmtpPort > 0 ? config.SmtpPort : 587;

                bool enableSsl = config.EnableSsl;

                string senderEmail = config.SenderEmail?.Trim();
                string senderPassword = config.SenderPassword;

                if (string.IsNullOrWhiteSpace(senderEmail) || string.IsNullOrWhiteSpace(senderPassword))
                    throw new Exception("Sender email or password is missing in config.");

                try
                {
                    using (MailMessage message = new MailMessage())
                    using (SmtpClient smtp = new SmtpClient(smtpHost, smtpPort))
                    {
                        smtp.EnableSsl = enableSsl;
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.Timeout = 20000;

                        message.From = new MailAddress(senderEmail.Trim());
                        message.To.Add(new MailAddress(recipentEmail.Trim()));
                        message.Subject = subject;
                        message.Body = body;

                        await smtp.SendMailAsync(message);
                    }
                }
                catch (SmtpException ex)
                {
                    throw new Exception("SMTP failed: " + ex.StatusCode + " - " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Email error: " + ex.Message);
                }
            }
        }
    }
}