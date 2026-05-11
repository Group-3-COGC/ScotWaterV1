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

        }


        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        //  to avoid creating duplicate seed data.
    }
}

