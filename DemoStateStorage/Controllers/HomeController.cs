using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoStateStorage.Controllers
{
    // Pour contsruire la BD : aspnet_regsql.exe -E -S .\SQLEXPRESS -A mrp -d StorageDB
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["Personne"] = "Ali MAKRI";
            return View();
        }
        public ActionResult Consulter()
        {
            ViewBag.Personne = Session["Personne"];
            return View();
        }
    }
}