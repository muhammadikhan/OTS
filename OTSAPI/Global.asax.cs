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
                try
                {
                    if (ConfigurationManager.AppSettings["isStagging"].ToString().ToUpper().Contains("TRUE"))
                        return ConfigurationManager.ConnectionStrings["StaggingConnectionString"].ConnectionString;
                    else
                        return ConfigurationManager.ConnectionStrings["LiveConnectionString"].ConnectionString;
                }
                catch (System.Exception ex)
                {
                return ex.ToString();
                }
            }
        }
        #endregion
    }
}
