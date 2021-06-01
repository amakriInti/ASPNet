using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;

namespace DemoCache.Controllers
{
    public class HomeController : Controller
    {
        private Repository Repo = new Repository();

        public HomeController()
        {
            MemoryCache.Default.AddOrGetExisting(
                "MaListe",
                Repo.Get(),
                DateTime.Now.AddSeconds(10)
                );
        }
        [OutputCache(Duration = 5)]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 30, VaryByParam ="a")]
        public ActionResult About(int a = 0)
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Parametre = a;
            return View();
        }

        public ActionResult Contact()
        {
            var liste = MemoryCache.Default.Get("MaListe");

            return View(liste);
        }

        public ActionResult ConfigCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.Public);

            return View();
        }

    }
}