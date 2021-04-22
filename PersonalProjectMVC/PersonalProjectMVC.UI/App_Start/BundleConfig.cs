using System.Web;
using System.Web.Optimization;

namespace PersonalProjectMVC.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                    "~/Content/vendor/php-email-form/validate.js",
                    "~/Content/vendor/counterup/counterup.min.js",
                    "~/Content/vendor/owl.carousel/owl.carousel.min.js",
                    "~/Content/vendor/isotope-layout/isotope.pkgd.min.js",
                    "~/Content/vendor/venobox/venobox.min.js",
                    "~/Scripts/js/main.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/icofont/icofont.min.css",
                       "~/Content/vendor/remixicon/remixicon.css",
                       "~/Content/vendor/owl.carousel/assets/owl.carousel.min.css",
                       "~/Content/vendor/boxicons/css/boxicons.min.css",
                       "~/Content/vendor/venobox/venobox.css",
                       "~/Content/css/style.css"
                      ));
        }
    }
}
