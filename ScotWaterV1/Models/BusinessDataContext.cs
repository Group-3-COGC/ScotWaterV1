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
        }//end of seed method

    }//end if BusinessDatabaseInitialiser class
}
