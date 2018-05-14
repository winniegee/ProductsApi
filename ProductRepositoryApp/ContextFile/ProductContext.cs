using ProductRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductRepositoryApp.ContextFile
{
    public class ProductContext :DbContext
    {
        public ProductContext() :base($"name={nameof(ProductContext)}")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}