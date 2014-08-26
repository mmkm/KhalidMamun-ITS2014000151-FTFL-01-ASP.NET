using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelPassingFromControllerToPartialView.Models;

namespace ModelPassingFromControllerToPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Student aStudent = new Student() {Name = "Pappu", RegNo = "76373"};
            Student student2 = new Student() { Name = "Zamil", RegNo = "7676" };
            List<Student> students = new List<Student>();
            students.Add(aStudent);
            students.Add(student2);
            return View(students);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}