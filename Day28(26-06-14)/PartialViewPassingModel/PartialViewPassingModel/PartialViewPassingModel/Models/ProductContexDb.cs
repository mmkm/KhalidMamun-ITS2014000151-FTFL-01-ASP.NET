using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PartialViewPassingModel.Models
{
    public class ProductContexDb :DbContext
    {
        public DbSet<Product> Products { set; get; } 
    }
}