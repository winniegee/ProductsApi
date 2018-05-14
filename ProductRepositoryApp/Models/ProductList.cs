using ProductRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductRepositoryApp
{
    public static class ProductList
    {
           public static List<Product> GetProductsList() {  
            var category1 = new Category() { Name = "Mobile Phones" };
            var category2 = new Category() { Name = "Laptops" };
            var category3 = new Category() { Name = "Wristwatches" };
            List<Product> ProductList = new List<Product> {
            new Product()
            {
                Name = "Infinix",
                Price = 54000,
                Category = category1,
                Description = "A good android phone"
            },
            new Product()
            {
                Name = "Tecno",
                Price = 56000,
                Category = category1,
                Description = "A great android phone from Tecno"
            },
             new Product()
            {
                Name = "Infinix",
                Price = 54000,
                Category = category1,
                Description = "A good android phone"
            },
           new Product()
            {
                Name = "HP",
                Price = 68000,
                Category = category2,
                Description = "A 7th generation laptop"
            },
            new Product()
            {
                Name = "Lenovo",
                Price = 104000,
                Category =category2,
                Description = "A dual partitioned laptop"
            },
                new Product()
            {
                Name = "MK",
                Price = 120000,
                Category = category3,
                Description = "Quality Michael Kors"
            },
                new Product()
            {
                Name = "Dolce",
                Price = 65200,
                Category = category3,
                Description = "Quality Dolce and Gabbana's "
            }};



            return ProductList;
        }
    }
}