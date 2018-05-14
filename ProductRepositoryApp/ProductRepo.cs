using ProductRepositoryApp.ContextFile;
using ProductRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductRepositoryApp
{
    public class ProductRepo : IProductRepository
    {
        private ProductContext ProductContext;
        public ProductRepo()
        {
             ProductContext = new ProductContext();
        }
       
        public IEnumerable<Product> GetProduct()
        {
            return ProductContext.Set<Product>().ToList();
        }
    }
}