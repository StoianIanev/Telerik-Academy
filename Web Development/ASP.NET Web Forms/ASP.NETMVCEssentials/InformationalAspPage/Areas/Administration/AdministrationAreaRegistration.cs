﻿using System.Web.Mvc;

namespace InformationalAspPage.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                 "Administration_default",
                 "Administration/{controller}/{action}/{id}",
                 new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "InformationalAspPage.Areas.Administration.Controllers" }
            );
        }
    }
}