using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShoppingSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "WHome", action = "Index", id = UrlParameter.Optional },
                namespaces:new string[] { "ShoppingSystem.Areas.Web.Controllers" }
            ).DataTokens.Add("area", "Web"); ;
        }
    }
}
