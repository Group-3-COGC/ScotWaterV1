using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ScotWaterV1.Models
{
    public class BusinessDataContext:DbContext
    {
        //DBSet <BusinessUser> represents a business table in the database
        public DbSet<BusinessUser> BusinessUser { get; set; }

        //DBSet<StaffUser> represents the Staff table in the database
        public DbSet<StaffUser> StaffUser { get; set; }

        //DBSet<AdminUsers> represents the Admin table in the database
        public DbSet<AdminUsers> AdminUsers { get; set; }

        //DBSet<BusinessBills> represents the Bills table in the database
        public DbSet<BusinessBills> BusinessBills { get; set; }

        //DBSet<WaterUsage> represents the water usage table in the database
        public DbSet<WaterUsage> WaterUsage { get; set; }

        //this is the constructor that initialises the context  with the specified connection string
        //the base keyword passes the connection string name to the DbContext class
        public BusinessDataContext() : base("BusinessAppConnection")
        {

        }
    }//end of BusinessDataContext class

    public class BusinessDatabaseInitialiser : DropCreateDatabaseAlways<BusinessDataContext>
    {
        protected override void Seed(BusinessDataContext context)
        {
            base.Seed(context);

            //create a few users
            BusinessUser business1 = new BusinessUser()
            {
                CompanyName = "Business 1",
                ContactName = "John Smith",
                ContactEmail = "business1@test.com",
                Postcode = "G1 2AB"
            };

            BusinessUser business2 = new BusinessUser()
            {
                CompanyName = "Business 2",
                ContactName = "James May",
                ContactEmail = "business2@test.com",
                Postcode = "G2 3CD"
            };

            BusinessUser business3 = new BusinessUser()
            {
                CompanyName = "City of Glasgow College",
                ContactName = "Mohammed Manasereh",
                ContactEmail = "mohammed@test.com",
                Postcode = "G3 BGD"
            };

            //add BusinessUsers to their respective tables
            context.BusinessUser.Add(business1);
            context.BusinessUser.Add(business2);
            context.BusinessUser.Add(business3);
            context.SaveChanges();

            //create staff user
            StaffUser staffuser1 = new StaffUser()
            {
                staffUsername = "Jack",
                staffPassword = "5678"
            };

            StaffUser staffuser2 = new StaffUser()
            {
                staffUsername = "Leon",
                staffPassword = "3456"
            };

            context.StaffUser.Add(staffuser1);
            context.StaffUser.Add(staffuser2);
            context.SaveChanges();

            //admin user table
            AdminUsers adminuser1 = new AdminUsers()
            {
                AdminUsername = "Dean",
                AdminPassword = "333"
            };

            AdminUsers adminuser2 = new AdminUsers()
            {
                AdminUsername = "Antoin",
                AdminPassword = "444"
            };

            context.AdminUsers.Add(adminuser1);
            context.AdminUsers.Add(adminuser2);

            WaterUsage waterusage1 = new WaterUsage()
            {
                FreshwaterUnitsUsed = 120,
                IsLowReserve = false,
                RecycledUnits = 20,
                ReadingDate = DateTime.Now,

                BusinessID = business1.BusinessID,
                StaffUserID = staffuser1.StaffUserID
            };

            WaterUsage waterusage2 = new WaterUsage()
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

            BusinessBills businessbill1 = new BusinessBills()
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

            BusinessBills businessbill2 = new BusinessBills()
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
            context.SaveChanges();

        }//end of seed method

    }//end if BusinessDatabaseInitialiser class
}
