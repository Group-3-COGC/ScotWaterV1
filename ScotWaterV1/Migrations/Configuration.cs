namespace ScotWaterV1.Migrations
{
    using ScotWaterV1.Core;
    using ScotWaterV1.Models;    
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Channels;

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
        
            if (!context.StaffUser.Any())
            {
                context.StaffUser.AddOrUpdate(
                    s => s.staffUsername,
                    new StaffUser
                    {
                        staffUsername = "Jack",
                        staffPassword = PasswordSecurity.HashPassword("5678")
                    },
                    new StaffUser
                    {
                        staffUsername = "Leon",
                        staffPassword = PasswordSecurity.HashPassword("3456")
                    }
                );
            }

            if (!context.AdminUsers.Any())
            {
                context.AdminUsers.AddOrUpdate(
                    a => a.AdminUsername,
                    new AdminUsers
                    {
                        AdminUsername = "Dean",
                        AdminPassword = PasswordSecurity.HashPassword("333")
                    },
                    new AdminUsers
                    {
                        AdminUsername = "Antoin",
                        AdminPassword = PasswordSecurity.HashPassword("444")
                    }
                );
            }
        }

        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        //  to avoid creating duplicate seed data.
    }
}

