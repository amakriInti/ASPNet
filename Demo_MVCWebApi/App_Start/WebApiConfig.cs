using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Demo_MVCWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web
            // https://docs.microsoft.com/fr-fr/aspnet/web-api/overview/web-api-routing-and-actions/routing-and-action-selection

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RoutePersonne",
                routeTemplate: "api/personne/{controller}/{ville}",
                defaults: new { ville = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "Route1",
                routeTemplate: "api/{controller}/{entier}",
                defaults: new {  },
                constraints: new { entier = @"\d+" }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
