﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebDevLab5.App_Start;

namespace WebDevLab5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyInjectionConfig.Register();

            log4net.Config.XmlConfigurator.Configure();
        }
    }
}