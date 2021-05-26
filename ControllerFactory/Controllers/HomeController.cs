using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerFactory.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var s = System.IO.File.ReadAllText(@"d:\texte.txt");
            return s;
        }

        public ActionResult About()
        {
            System.IO.File.WriteAllText(@"d:\texte.txt", "Passage 2");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}