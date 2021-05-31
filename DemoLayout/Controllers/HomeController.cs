using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoLayout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Vue avec Layout
            return View();
        }
        public ActionResult Index2()
        {
            // Vue sans Layout
            return View();
        }
        public ActionResult Index3()
        {
            // Vue avec autre Layout
            return View();
        }
        public ActionResult Index4()
        {
            // Vue avec layout2 et renderSection
            return View();
        }
        public ActionResult Index5()
        {
            // Vue avec layout2 et renderSection
            return View();
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