namespace ScotWaterV1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Channels;
    using ScotWaterV1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ScotWaterV1.Models.BusinessDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ScotWaterV1.Models.BusinessDataContext";
        }

        protected override void Seed(ScotWaterV1.Models.BusinessDataContext context)
        {
            context.EmailConfigs.AddOrUpdate(
                e => e.SenderEmail,
                new EmailConfigs
                {
                    SenderEmail = "yourcompany@gmail.com",
                    SenderPassword = "your_app_password",
                    SmtpHost = "smtp.gmail.com",
                    SmtpPort = 587,
                    EnableSsl = true
                }
            );


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
