using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

// Les retours du controller
namespace Retours.Controllers
{
    public class HomeController : Controller
    {
        // String
        public string Index1()
        {
            //return "Essai avec un string";
            return "<html><body><h1>Une page Html</h1></body></html>";
        }
        public Personne Index2()
        {
            return new Personne { Nom = "MAKRI", Ville = "Lyon" };
        }
        // ContentResult
        public ActionResult Index3()
        {
            var result = new ContentResult();
            result.ContentEncoding = Encoding.UTF8;
            result.Content = "<html><body><p>Salut</p></body></html>";
            return result;
        }
        // EmptyResult
        public ActionResult Index4()
        {
            var result = new EmptyResult();
            return result;
        }
        // FileContentResult
        public ActionResult Index5()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"d:\inti\test.txt");
            string fileName = "essai.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        // JavascriptResult
        public ActionResult Index6()
        {
            var script = "<script>function a (){alert('Hello');}</script>";
            return new JavaScriptResult() { Script = script };
        }
        // JSonResult
        public ActionResult Index7()
        {
            var result = new JsonResult();
            result.Data = @"{""a"":1;""b"":""test""}";
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }
        // RedirectResult
        public ActionResult Index8()
        {
            var result = new RedirectResult("http://google.fr");
            return result;
        }
        // RedirectToRouteResult
        public string Index10()
        {
            return "Reroutage";
        }
        public ActionResult Index9()
        {
            return new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "Autre" }));
        }
        public ActionResult Index9Bis()
        {
            return new RedirectToRouteResult("route1", new RouteValueDictionary(new { action = "Index"}));
        }

    }
    public class Personne
    {
        public string Nom;
        public string Ville;
        public override string ToString()
        {
            return $"{Nom} {Ville}";
        }
    }
}