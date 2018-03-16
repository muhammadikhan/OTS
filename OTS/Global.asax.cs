using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
namespace OTS
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
    public static class GlobalSettings
    {
        public static string WebAPIURL
        {
            get
            {
                if (ConfigurationManager.AppSettings["isStagingSite"].ToString().ToUpper().Contains("TRUE"))
                    return ConfigurationManager.AppSettings["WebApiURL_Staging"];
                else
                    return ConfigurationManager.AppSettings["WebApiURL_Live"];
            }
        }
        public static int WebAPITimeout
        {
            get
            {
                try
                {
                    return int.Parse(ConfigurationManager.AppSettings["WebApiTimeout"].ToString());
                }
                catch
                {
                    return 9000;
                }
            }
        }
    }
}
