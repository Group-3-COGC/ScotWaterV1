namespace ScotWaterV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailConfigs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailConfigs",
                c => new
                    {
                        EmailSettingsID = c.Int(nullable: false, identity: true),
                        SenderEmail = c.String(nullable: false),
                        SenderPassword = c.String(nullable: false),
                        SmtpHost = c.String(nullable: false),
                        SmtpPort = c.Int(nullable: false),
                        EnableSsl = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmailSettingsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmailConfigs");
        }
    }
}
