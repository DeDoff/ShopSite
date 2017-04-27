namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyltipleFields : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopProducts",
                c => new
                    {
                        Shop_ShopId = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Shop_ShopId, t.Product_ProductId })
                .ForeignKey("dbo.Shops", t => t.Shop_ShopId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Shop_ShopId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.ShopProducts", "Shop_ShopId", "dbo.Shops");
            DropIndex("dbo.ShopProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.ShopProducts", new[] { "Shop_ShopId" });
            DropTable("dbo.ShopProducts");
        }
    }
}
