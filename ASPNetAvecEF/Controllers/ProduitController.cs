using ASPNetAvecEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetAvecEF.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index(string id)
        {
            int i; Produits liste = null;

            if (int.TryParse(id, out i))
                liste = new Produits(i);
            else
                liste = new Produits(id);
            return View(liste);
        }
        public string Test(string a, string b)
        {
            return a + b;
        }
    }
}