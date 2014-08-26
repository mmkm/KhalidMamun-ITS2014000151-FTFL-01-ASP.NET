using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product p1 = new Product() { Name = "Ice cream", Price = 250 };
            Product p2 = new Product() { Name = "Potato", Price = 20 };
            Product p3 = new Product() { Name = "Burger", Price = 300 };

            List<Product> productList = new List<Product>();
            productList.Add(p1);
            productList.Add(p2);
            productList.Add(p3);            
            return View(productList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
