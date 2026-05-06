namespace ScotWaterV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUsers",
                c => new
                    {
                        AdminUserID = c.Int(nullable: false, identity: true),
                        AdminUsername = c.String(nullable: false),
                        AdminPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminUserID);
            
            CreateTable(
                "dbo.BusinessBills",
                c => new
                    {
                        BusinessBillID = c.Int(nullable: false, identity: true),
                        BillDate = c.DateTime(nullable: false),
                        TotalCharges = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VAT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BusinessFinalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BusinessID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessBillID)
                .ForeignKey("dbo.BusinessUsers", t => t.BusinessID, cascadeDelete: true)
                .Index(t => t.BusinessID);
            
            CreateTable(
                "dbo.BusinessUsers",
                c => new
                    {
                        BusinessID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Postcode = c.String(),
                        ContactName = c.String(),
                        ContactNumber = c.String(),
                        ContactEmail = c.String(),
                        AccountName = c.String(),
                        Region = c.String(),
                        AccountNumber = c.String(),
                        SortCode = c.String(),
                    })
                .PrimaryKey(t => t.BusinessID);
            
            CreateTable(
                "dbo.WaterUsages",
                c => new
                    {
                        WaterUsageID = c.Int(nullable: false, identity: true),
                        FreshwaterUnitsUsed = c.Int(nullable: false),
                        RecycledUnits = c.Int(nullable: false),
                        ReadingDate = c.DateTime(nullable: false),
                        BusinessID = c.Int(nullable: false),
                        StaffUserID = c.Int(nullable: false),
                        IsLowReserve = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.WaterUsageID)
                .ForeignKey("dbo.BusinessUsers", t => t.BusinessID, cascadeDelete: true)
                .ForeignKey("dbo.StaffUsers", t => t.StaffUserID, cascadeDelete: true)
                .Index(t => t.BusinessID)
                .Index(t => t.StaffUserID);
            
            CreateTable(
                "dbo.StaffUsers",
                c => new
                    {
                        StaffUserID = c.Int(nullable: false, identity: true),
                        staffUsername = c.String(nullable: false),
                        staffPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StaffUserID);
            
            CreateTable(
                "dbo.PricingConfigs",
                c => new
                    {
                        PricingConfigID = c.Int(nullable: false, identity: true),
                        FreshwaterPricePerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecycledPricePerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LowReserveMultiplier = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VATRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PricingConfigID);
            
            CreateTable(
                "dbo.ReserveConfigs",
                c => new
                    {
                        ReserveConfigID = c.Int(nullable: false, identity: true),
                        CurrentReservePercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ReserveConfigID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WaterUsages", "StaffUserID", "dbo.StaffUsers");
            DropForeignKey("dbo.WaterUsages", "BusinessID", "dbo.BusinessUsers");
            DropForeignKey("dbo.BusinessBills", "BusinessID", "dbo.BusinessUsers");
            DropIndex("dbo.WaterUsages", new[] { "StaffUserID" });
            DropIndex("dbo.WaterUsages", new[] { "BusinessID" });
            DropIndex("dbo.BusinessBills", new[] { "BusinessID" });
            DropTable("dbo.ReserveConfigs");
            DropTable("dbo.PricingConfigs");
            DropTable("dbo.StaffUsers");
            DropTable("dbo.WaterUsages");
            DropTable("dbo.BusinessUsers");
            DropTable("dbo.BusinessBills");
            DropTable("dbo.AdminUsers");
        }
    }
}
