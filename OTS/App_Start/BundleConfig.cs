using System.Web;
using System.Web.Optimization;

namespace OTS
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery_and_bootstrap").Include(
                            "~/Content/js/jquery.js",
                            "~/Content/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/customJS").Include(
                            "~/Content/js/scripts.js",
                            "~/Content/js/html5shiv.js",
                            "~/Content/js/less-1.3.3.js"));

            //Custom Bundles Added by Imran Khan.
            bundles.Add(new StyleBundle("~/Content/CustomCSS").Include(
            "~/Content/css/bootstrap.css",
            "~/Content/css/style.css",
            "~/Content/css/style_OTS_portal.css"
            ));

        }
    }
}