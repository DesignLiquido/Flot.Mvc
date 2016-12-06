using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Flot.Mvc.Sample.FlotBundleConfig), "RegisterBundles")]

namespace Flot.Mvc.Sample
{
    public class FlotBundleConfig
    {
        public static void RegisterBundles()
        {
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/flot")
                                                    .Include("~/Scripts/flot/excanvas*")
                                                    .Include("~/Scripts/flot/jquery.flot.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/flot/addons")
                                                    .Include("~/Scripts/flot/jquery.flot.canvas*")
                                                    .Include("~/Scripts/flot/jquery.flot.categories*")
                                                    .Include("~/Scripts/flot/jquery.flot.crosshair*")
                                                    .Include("~/Scripts/flot/jquery.flot.errorbars*")
                                                    .Include("~/Scripts/flot/jquery.flot.fillbetween*")
                                                    .Include("~/Scripts/flot/jquery.flot.image*")
                                                    .Include("~/Scripts/flot/jquery.flot.navigate*")
                                                    .Include("~/Scripts/flot/jquery.flot.pie*")
                                                    .Include("~/Scripts/flot/jquery.flot.resize*")
                                                    .Include("~/Scripts/flot/jquery.flot.selection*")
                                                    .Include("~/Scripts/flot/jquery.flot.stack*")
                                                    .Include("~/Scripts/flot/jquery.flot.symbol*")
                                                    .Include("~/Scripts/flot/jquery.flot.threshold*")
                                                    .Include("~/Scripts/flot/jquery.flot.time*"));
        }
    }
}