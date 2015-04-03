using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InformationalAspPage
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BookAuthor",
                url: "Books/{id}/BookAuthor/",
                defaults: new { controller = "Books", action = "BookAuthor", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AboutAuthor",
                url: "Books/{id}/AboutAuthor/",
                defaults: new { controller = "Books", action = "AboutAuthor", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "InformationalAspPage.Controllers" }
            );
        }
    }
}
