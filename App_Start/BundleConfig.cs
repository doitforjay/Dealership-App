using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include( "~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/respond.js")
                .Include("~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui")
                .Include("~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryui")
               .Include("~/Content/themes/base/all.css"));

            bundles.Add(new ScriptBundle("~/bundles/table").Include(
                        "~/Scripts/DataTables/jquery.dataTables.js"));
                       
            ScriptBundle Bnd1 = new ScriptBundle("~/Scripts/jquery");
            Bnd1.Include("~/Scripts/selectScript.js");
            Bnd1.Include("~/Scripts/Dialog.js");
            Bnd1.Include("~/Scripts/getRow.js");
            bundles.Add(Bnd1);
            
            StyleBundle bnd2 = new StyleBundle("~/Styles/css");
            bnd2.Include("~/Content/modal.css");
            bnd2.Include("~/Content/Details.css");
            bnd2.Include("~/Content/DealersLayout.css");
            bundles.Add(bnd2);

        }
    }
}