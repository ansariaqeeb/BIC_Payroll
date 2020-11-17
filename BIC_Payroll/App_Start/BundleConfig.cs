using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BIC_Payroll.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        { 
            //Jquery bundle
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/js/libs/jquery-{version}.js"));  

            //CSS For Layout 
            bundles.Add(new StyleBundle("~/bundles/LayoutCommoncss").Include("~/css/bootstrap.min.css",
                "~/css/font-awesome.min.css",
                "~/css/smartadmin-production-plugins.min.css",
                "~/css/smartadmin-production.min.css",
                "~/css/smartadmin-skins.min.css",
                "~/css/smartadmin-rtl.min.css",
                "~/css/demo.min.css",
                "~/css/toastr.min.css",
                "~/css/ERPDesign.css",
                "~/css/select2.min.css"));

            //js For Layout
            bundles.Add(new ScriptBundle("~/bundles/LayoutJS").Include("~/Scripts/jquery-{version}.js",
                "~/js/app.config.js",
                "~/js/plugin/jquery-touch/jquery.ui.touch-punch.min.js",
                "~/js/bootstrap/bootstrap.min.js",
                "~/js/smartwidgets/jarvis.widget.min.js",
                "~/js/plugin/jquery-validate/jquery.validate.min.js",
                "~/js/plugin/select2/select2.min.js",
                "~/js/plugin/bootstrap-slider/bootstrap-slider.min.js",
                "~/js/plugin/msie-fix/jquery.mb.browser.min.js",
                "~/js/plugin/fastclick/fastclick.min.js",
                "~/js/app.min.js",
                "~/js/toastr.min.js",
                "~/js/ProjectCommon.js",
                "~/js/plugin/datatables/jquery.dataTables.min.js",
                "~/js/plugin/datatables/dataTables.colVis.min.js",
                "~/js/plugin/datatables/dataTables.tableTools.min.js",
                "~/js/plugin/datatables/dataTables.bootstrap.min.js",
                "~/js/plugin/datatable-responsive/datatables.responsive.min.js"
                ));
            
            BundleTable.EnableOptimizations = true;
        }
    }
}