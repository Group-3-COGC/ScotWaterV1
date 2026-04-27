using System;
using System.Data.Entity;
using ScotWaterV1.Core;

namespace ScotWaterV1.Models
{
   
    // DATABASE CONTEXT 
   
    public class BusinessDataContext : DbContext
    {
        public BusinessDataContext() : base("BusinessAppConnection")
        {
            Database.SetInitializer(new BusinessDatabaseInitialiser());
        }

        public DbSet<BusinessUser> BusinessUser { get; set; }
        public DbSet<StaffUser> StaffUser { get; set; }
        public DbSet<AdminUsers> AdminUsers { get; set; }
        public DbSet<BusinessBills> BusinessBills { get; set; }
        public DbSet<WaterUsage> WaterUsage { get; set; }

        // NEW TABLES
        public DbSet<PricingConfig> PricingConfigs { get; set; }
        public DbSet<ReserveConfig> ReserveConfigs { get; set; }
    }

   
    // DATABASE INITIALISER (SEED DATA)
  
    public class BusinessDatabaseInitialiser
        : CreateDatabaseIfNotExists<BusinessDataContext>
    {
        protected override void Seed(BusinessDataContext context)
        {
            
            // BUSINESS USERS
            
            var business1 = new BusinessUser()
            {
                CompanyName = "Business 1",
                ContactName = "John Smith",
                ContactEmail = "business1@test.com",
                Postcode = "G1 2AB"
            };

            var business2 = new BusinessUser()
            {
                CompanyName = "Business 2",
                ContactName = "James May",
                ContactEmail = "business2@test.com",
                Postcode = "G2 3CD"
            };

            var business3 = new BusinessUser()
            {
                CompanyName = "City of Glasgow College",
                ContactName = "Mohammed Manasereh",
                ContactEmail = "mohammed@test.com",
                Postcode = "G3 BGD"
            };

            context.BusinessUser.Add(business1);
            context.BusinessUser.Add(business2);
            context.BusinessUser.Add(business3);
            context.SaveChanges();

           
            // STAFF USERS
           
            var staffuser1 = new StaffUser()
            {
                staffUsername = "Jack",
                staffPassword = PasswordSecurity.HashPassword("5678")
            };

            var staffuser2 = new StaffUser()
            {
                staffUsername = "Leon",
                staffPassword = PasswordSecurity.HashPassword("3456")
            };

            context.StaffUser.Add(staffuser1);
            context.StaffUser.Add(staffuser2);
            context.SaveChanges();

          
            // ADMIN USERS
            
            var adminuser1 = new AdminUsers()
            {
                AdminUsername = "Dean",
                AdminPassword = PasswordSecurity.HashPassword("333")
            };

            var adminuser2 = new AdminUsers()
            {
                AdminUsername = "Antoin",
                AdminPassword = PasswordSecurity.HashPassword("444")
            };

            context.AdminUsers.Add(adminuser1);
            context.AdminUsers.Add(adminuser2);
            context.SaveChanges();

            // WATER USAGE
           
            var waterusage1 = new WaterUsage()
            {
                FreshwaterUnitsUsed = 120,
                IsLowReserve = false,
                RecycledUnits = 20,
                ReadingDate = DateTime.Now,
                BusinessID = business1.BusinessID,
                StaffUserID = staffuser1.StaffUserID
            };

            var waterusage2 = new WaterUsage()
            {
                FreshwaterUnitsUsed = 200,
                IsLowReserve = true,
                RecycledUnits = 40,
                ReadingDate = DateTime.Now.AddDays(-10),
                BusinessID = business2.BusinessID,
                StaffUserID = staffuser2.StaffUserID
            };

            context.WaterUsage.Add(waterusage1);
            context.WaterUsage.Add(waterusage2);
            context.SaveChanges();

          
            // BUSINESS BILLS
            var businessbill1 = new BusinessBills()
            {
                BillDate = waterusage1.ReadingDate,
                TotalCharges = 25.00m,
                TotalDiscount = 2.00m,
                DiscountRate = 0.08m,
                SubTotal = 23.00m,
                VAT = 4.60m,
                BusinessFinalCost = 27.60m,
                BusinessID = business1.BusinessID
            };

            var businessbill2 = new BusinessBills()
            {
                BillDate = waterusage2.ReadingDate,
                TotalCharges = 40.00m,
                TotalDiscount = 5.00m,
                DiscountRate = 0.125m,
                SubTotal = 35.00m,
                VAT = 7.00m,
                BusinessFinalCost = 42.00m,
                BusinessID = business2.BusinessID
            };

            context.BusinessBills.Add(businessbill1);
            context.BusinessBills.Add(businessbill2);

            
            // PRICING CONFIG 
            
            var pricing = new PricingConfig()
            {
                FreshwaterPricePerUnit = 1.00m,
                RecycledPricePerUnit = 0.50m,
                LowReserveMultiplier = 1.5m,
                DiscountRate = 0.10m,
                VATRate = 0.20m
            };

            context.PricingConfigs.Add(pricing);

            
            // RESERVE CONFIG 
           
            var reserve = new ReserveConfig()
            {
                CurrentReservePercentage = 80m
            };

            context.ReserveConfigs.Add(reserve);

            context.SaveChanges();
        }
    }
}
