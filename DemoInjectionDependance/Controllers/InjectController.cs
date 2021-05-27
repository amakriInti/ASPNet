using DemoInjectionDependance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoInjectionDependance.Controllers
{
    public class InjectController : Controller
    {
        public IRepository Repo = null;
        public ILogo Logo = null;

        // L'instanciation du paramètre repo se fait dans NInject dans ce constructor
        public InjectController(IRepository repo, ILogo logo)
        {
            Repo = repo;
            Logo = logo;
        }
        public ActionResult Index()
        {
            ViewBag.Logo = Logo.Get();
            return View(Repo.Get());
        }
    }
}