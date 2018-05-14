using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ProductRepositoryApp.Controllers
{
    
    public class ProductController : Controller
    {
        // GET: Product 
        public ActionResult ProductList()
        {
            return View();
        }
    }
}