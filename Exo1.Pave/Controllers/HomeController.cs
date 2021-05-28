using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo1.Pave.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string code)
        {
            if (code == "1234") return RedirectToAction("Accueil");
            if (code != null) ViewBag.Erreur = "Code incorrect";
            return View();
        }

        public ActionResult accueil()
        {
            return View();
        }
    }
}