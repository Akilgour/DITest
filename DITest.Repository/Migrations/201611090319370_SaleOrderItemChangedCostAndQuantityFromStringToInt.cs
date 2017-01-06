namespace DITest.Repository.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SaleOrderItemChangedCostAndQuantityFromStringToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SaleOrderItem", "Cost", c => c.Int(nullable: false));
            AlterColumn("dbo.SaleOrderItem", "Quantity", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.SaleOrderItem", "Quantity", c => c.String());
            AlterColumn("dbo.SaleOrderItem", "Cost", c => c.String());
        }
    }
}