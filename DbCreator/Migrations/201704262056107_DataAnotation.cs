namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Shops", "ShopName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Shops", "ShopAddress", c => c.String(maxLength: 1024));
            AlterColumn("dbo.Shops", "WorkingTime", c => c.String(maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shops", "WorkingTime", c => c.String());
            AlterColumn("dbo.Shops", "ShopAddress", c => c.String());
            AlterColumn("dbo.Shops", "ShopName", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
        }
    }
}
