using ProductRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductRepositoryApp
{
    public class Category :BaseModel
    {
       
        
        public string Name { get; set; }
    }
}