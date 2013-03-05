using System.Web.Optimization;

namespace TD2013SignalRReplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/site")
                .Include("~/Scripts/shims.js")
                .Include("~/Scripts/Queue.js"));
        }
    }
}