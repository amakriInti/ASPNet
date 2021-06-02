using Demo_MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Demo_MVCWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var liste = new List<Personne> {
            new Personne{ Id=1, Nom="Alban", Ville="Agen"  },
            new Personne{ Id=2, Nom="Baltazar", Ville="Bern"  },
            new Personne{ Id=3, Nom="Carmen", Ville="Agen"  }
            };
            Application["Personne"] = liste;
        }
    }
}
