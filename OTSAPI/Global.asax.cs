using System.Configuration;
using System.Web;
using System.Web.Http;

namespace OTSAPI
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
        
    }
    public static class GlobalSettings
    {
        #region public Properties
        public static string GetConnectionString
        {
            get
            {
                    return "Imran";
                    //return ConfigurationManager.ConnectionStrings["ProjectConnection"].ConnectionString.Replace("@", "^").Replace("#", "~").Replace("!", "|");
            }
        }
        #endregion
    }
}
