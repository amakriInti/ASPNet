using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataFromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Index n° 1";
            ViewBag.Maintenant = DateTime.Now;

            ViewBag.Param1 = 1234;
            ViewBag.Param2 = "Paramètre 2";
            var s = new A { Content = "Données provenant de Index" };
            return View(s);
        }
        public ActionResult Index2()
        {
            return View();
        }

    }
    public class A
    {
        public string Content;
    }
}