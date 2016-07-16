using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PartialViewExample.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js")
                   .Include("~/scripts/jquery-{version}.js")
                   .Include("~/scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                   .Include("~/Content/bootstrap.css"));
        }
    }
}