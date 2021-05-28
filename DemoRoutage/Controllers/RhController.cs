using DemoRoutage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoRoutage.Controllers
{
    public class RhController : Controller
    {
        // GET: Rh
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Fiche(string service, int salarie)
        {
            return View(new FicheSalarie { Service=service, Salarie=salarie});
        }
    }
}