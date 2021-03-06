﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CEMS_Study_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //ACCESS METHOD ENABLED SO THAT ROUTE ATTRIBUTES IN CONTROLLER
            routes.MapMvcAttributeRoutes();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Part75",
                url: "Part75/{action}/{id}",
                defaults: new { controller = "Part75", action = "Part75", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Part75EMP",
                url: "Part75EMP/{action}/{id}",
                defaults: new { controller = "Part75EMP", action = "Part75EMP", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Part60AppB",
                url: "Part60AppB/{action}/{id}",
                defaults: new { controller = "Part60AppB", action = "Part60AppB", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ECMPS",
                url: "ECMPS/{action}/{id}",
                defaults: new { controller = "ECMPS", action = "EmissionsReporting", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Acronyms",
                url: "Acronyms",
                defaults: new { controller = "Acronyms", action = "Acronyms", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Definitions",
                url: "Definitions",
                defaults: new { controller = "Definitions", action = "Definitions", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "UnitsOfMeasure",
                url: "UnitsOfMeasure",
                defaults: new { controller = "UnitsOfMeasure", action = "UnitsOfMeasure", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Formulas",
                url: "Formulas",
                defaults: new { controller = "Formulas", action = "Formulas", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Template",
                url: "Template",
                defaults: new { controller = "Template", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{id}",
                defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
