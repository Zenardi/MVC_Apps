using System.Web;
using System.Web.Optimization;

namespace Crud
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                                        "~/Scripts/DataTables/dataTables.bootstrap.min.js",
                                        "~/Scripts/DataTables/dataTables.colReorder.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-spacelab.css",
                      "~/Content/DataTables/css/jquery.dataTables.min.css",
                      "~/Content/DataTables/css/jquery.dataTables_themeroller.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.min.css",
                      "~/Content/DataTables/css/colReorder.bootstrap.min.css",
                      "~/Content/jquery-ui.min.css",
                      "~/Content/jquery-ui.theme.min.css",
                      "~/Content/site.css"));
        }
    }
}
