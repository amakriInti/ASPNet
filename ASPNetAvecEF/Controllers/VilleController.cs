using ASPNetAvecEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetAvecEF.Controllers
{
    public class VilleController : Controller
    {
        // GET: Ville
        public ActionResult Index()
        {
            var liste = new Villes();
            return View(liste);
        }
    }
}