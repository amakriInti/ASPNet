using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo1.Pave.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string code)
        {
            if (code == "1234")
            {
                Session["Passe"] = true;
                return RedirectToAction("Accueil");
            }
            if (code != null) ViewBag.Erreur = "Code incorrect";
            return View();
        }

        public ActionResult Accueil()
        {
            if (Session["Passe"] == null) return RedirectToAction("Index");
            return View();
        }

        [HttpPost]
        public ActionResult Accueil(string choix)
        {
            switch (choix)
            {
                case "Album": return RedirectToAction("Album");
                case "PhotosNom": return RedirectToAction("Photos", new { id = "nom" });
                case "PhotosDate": return RedirectToAction("Photos", new { id = "date" });
            }
            return View();
        }
        public ActionResult Album()
        {
            if (Session["Passe"] == null) return RedirectToAction("Index");
            return View();
        }
        public ActionResult Photos(string id)
        {
            if (Session["Passe"] == null) return RedirectToAction("Index");
            return View();
        }

    }
}