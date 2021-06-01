using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AjaxContenu1()
        {
            return Content("Mise à jour depuis le serveur à " + DateTime.Now.ToString("HH:mm:ss"));
        }
        public ActionResult AjaxContenu2()
        {
            return Content("<p style='color:red'>Code html</p>");
        }
        public PartialViewResult AjaxVue()
        {
            return PartialView();
        }

    }
}