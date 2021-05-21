using PremierApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremierApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p = new Personne { Nom = "MAKRI", Ville = "Lyon" };
            var v =  View(p);
            return v;
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