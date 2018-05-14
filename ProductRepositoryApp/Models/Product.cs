using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductRepositoryApp.Models
{
    public class Product:BaseModel
    {
      
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
        [Required]
        public string Description { get; set; }

    }
}