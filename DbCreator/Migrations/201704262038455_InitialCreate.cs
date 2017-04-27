namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDescription = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ShopId = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        ShopAddress = c.String(),
                        WorkingTime = c.String(),
                    })
                .PrimaryKey(t => t.ShopId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
        }
    }
}
