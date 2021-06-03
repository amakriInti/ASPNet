using Demo2_MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2_MVCWebApi.Controllers
{
    public class HomeController : Controller
    {
        private Repository Repo = new Repository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var rencontre = Repo.GetMatches(id).FirstOrDefault();
            if (rencontre == null) return RedirectToAction("Index");
            return View(rencontre);
        }
    }
}