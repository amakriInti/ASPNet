using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerFactory.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            return View();
        }
    }
}