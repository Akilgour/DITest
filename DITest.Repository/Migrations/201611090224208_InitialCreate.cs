namespace DITest.Repository.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleOrder",
                c => new
                {
                    SaleOrderId = c.Int(nullable: false, identity: true),
                    FullName = c.String(),
                    AddressLineOne = c.String(),
                    AddressLineTwo = c.String(),
                })
                .PrimaryKey(t => t.SaleOrderId);

            CreateTable(
                "dbo.SaleOrderItem",
                c => new
                {
                    SaleOrderItemId = c.Int(nullable: false, identity: true),
                    SaleOrderId = c.Int(nullable: false),
                    Name = c.String(),
                    Cost = c.String(),
                    Quantity = c.String(),
                })
                .PrimaryKey(t => t.SaleOrderItemId)
                .ForeignKey("dbo.SaleOrder", t => t.SaleOrderId, cascadeDelete: true)
                .Index(t => t.SaleOrderId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.SaleOrderItem", "SaleOrderId", "dbo.SaleOrder");
            DropIndex("dbo.SaleOrderItem", new[] { "SaleOrderId" });
            DropTable("dbo.SaleOrderItem");
            DropTable("dbo.SaleOrder");
        }
    }
}