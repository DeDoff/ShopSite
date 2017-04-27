namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbCreator.Model.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DbCreator.Model.ShopDbContext";
        }

        protected override void Seed(DbCreator.Model.ShopDbContext context)
        {
            
        }
    }
}
