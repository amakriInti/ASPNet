using ASPNetAvecEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetAvecEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var liste = new Personnes();
            return View(liste);
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