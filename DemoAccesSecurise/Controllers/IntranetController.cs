using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAccesSecurise.Controllers
{
    [Authorize]
    public class IntranetController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employe()
        {
            return View();
        }
    }
}