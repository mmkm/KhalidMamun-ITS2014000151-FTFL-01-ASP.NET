using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;


namespace PartialViewPassingModel.Controllers
{
    public class ProductController : Controller
    {
        private ProductDbContext productDbContext = new ProductDbContext();

        public ActionResult Index()
        {
            var products = productDbContext.Products;
            return View(products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product aProduct)
        {
            productDbContext.Products.Add(aProduct);
            productDbContext.SaveChanges();
            return View();
        }
    }
}