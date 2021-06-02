using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoSession
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            System.Web.HttpContext.Current.Application["Compteur"] = 0;
        }
        protected void Session_Start()
        {
            System.Web.HttpContext.Current.Application["Compteur"]= (int) System.Web.HttpContext.Current.Application["Compteur"]+1;
        }
    }
}
