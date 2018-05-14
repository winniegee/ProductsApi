using ProductRepositoryApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductRepositoryApp
{
    interface IProductRepository
    {
       IEnumerable<Product> GetProduct();
    }
}