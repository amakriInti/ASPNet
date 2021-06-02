using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoSession.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            Session["personne"] = id;
            ViewBag.Compteur = System.Web.HttpContext.Current.Application["Compteur"];
            return View();
        }
        public ActionResult Ailleurs()
        {
            ViewBag.Personne = Session["personne"];
            return View();
        }
    }
}