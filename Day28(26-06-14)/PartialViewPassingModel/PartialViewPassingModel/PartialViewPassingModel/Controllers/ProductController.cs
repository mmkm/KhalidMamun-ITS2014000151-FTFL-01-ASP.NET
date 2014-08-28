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
        private ProductContexDb db=new ProductContexDb();
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="ProductId,Name,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                
                return RedirectToAction("Index");
                
            }
            return View(product);
        }
    }
}
