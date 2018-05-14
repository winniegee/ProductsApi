namespace ProductRepositoryApp.Migrations
{
    using ProductRepositoryApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductRepositoryApp.ContextFile.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductRepositoryApp.ContextFile.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var ProductSeed = ProductList.GetProductsList();
            context.Set<Product>().AddRange(ProductSeed);
            context.SaveChanges();


        }
    }
}
