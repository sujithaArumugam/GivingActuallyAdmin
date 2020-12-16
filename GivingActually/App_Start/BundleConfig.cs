using System.Web;
using System.Web.Optimization;

namespace GivingActually
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/dataTables.responsive.min.js", "~/Scripts/toastr.js",
                        "~/Scripts/lazy.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js", "~/Scripts/toastr.js"));

            //bundles.UseCdn = true;   //enable CDN support

            ////add link to jquery on the CDN
            //var cssCdnPath = "https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css";

            //bundles.Add(new ScriptBundle("~/bundles/jquery",
            //            cssCdnPath).Include(
            //            "~/Scripts/jquery-{version}.js"));


            bundles.Add(new StyleBundle("~/css/css").Include("~/css/bootstrap.css",
                "~/css/modern-business.css", "~/Content/Website.css"));



                      //"~/css/bootstrap.css", "~/Content/responsive.dataTables.min.css", "~/Content/jquery.dataTables.min.css",
                      //"~/css/modern-business.css", "~/Content/Website.css", "~/Content/toastr.css"));




           
                    BundleTable.EnableOptimizations = true;
        }
    }
}
