using ProductRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace ProductRepositoryApp.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductApiController : ApiController
    {
        private ProductRepo _productRepo;
        public ProductApiController()
        {
            _productRepo = new ProductRepo();
        }
       

        [Route("productlist")]
        public HttpResponseMessage GetProducts()
        {
            try
            {
                IEnumerable<Product> products = _productRepo.GetProduct();
                return this.Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.Created, products);
            }
            catch(Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.Created, ex.Message);
            }
        }
    }
}