namespace DITest.Repository.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Create_LargeObject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LargeObject",
                c => new
                {
                    LargeObjectId = c.Int(nullable: false, identity: true),
                    PropertyOne = c.String(),
                    PropertyTwo = c.String(),
                    PropertyThree = c.String(),
                    PropertyFour = c.String(),
                    PropertyFive = c.String(),
                    PropertySix = c.String(),
                    PropertySeven = c.String(),
                    PropertyEight = c.Int(nullable: false),
                    PropertyNine = c.Boolean(nullable: false),
                    PropertyTen = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.LargeObjectId);
        }

        public override void Down()
        {
            DropTable("dbo.LargeObject");
        }
    }
}