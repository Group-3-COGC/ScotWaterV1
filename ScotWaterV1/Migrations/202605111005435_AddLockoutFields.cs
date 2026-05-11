namespace ScotWaterV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLockoutFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminUsers", "FailedLoginAttempts", c => c.Int(nullable: false));
            AddColumn("dbo.AdminUsers", "IsLocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.StaffUsers", "FailedLoginAttempts", c => c.Int(nullable: false));
            AddColumn("dbo.StaffUsers", "IsLocked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffUsers", "IsLocked");
            DropColumn("dbo.StaffUsers", "FailedLoginAttempts");
            DropColumn("dbo.AdminUsers", "IsLocked");
            DropColumn("dbo.AdminUsers", "FailedLoginAttempts");
        }
    }
}
