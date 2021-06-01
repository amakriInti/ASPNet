using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DemoAccesSecurise.Controllers
{
    [Authorize]
    public class IntranetController : Controller
    {
        public IntranetController()
        {
            if (!Roles.RoleExists("Admin")) Roles.CreateRole("Admin");
            if (!Roles.IsUserInRole("ali.makri@gmail.fr", "Admin")) Roles.AddUserToRole("ali.makri@gmail.fr", "Admin");
            if (!Roles.IsUserInRole("paul@gmail.fr", "Admin")) Roles.AddUserToRole("paul@gmail.fr", "Admin");
        }
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employe()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}