namespace DITest.Repository.Migrations
{
    using SeedData;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DITest.Repository.Context.DITestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DITest.Repository.Context.DITestContext context)
        {
            SaleOrder.Seed(context);
            SaleOrderItem.Seed(context);
        }
    }
}