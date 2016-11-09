namespace DITest.Repository.Migrations
{
    using SeedData;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DITest.Repository.Context.DITestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DITest.Repository.Context.DITestContext context)
        {
            SaleOrder.Seed(context);
        }
    }
}
