﻿using System;
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

            //CSS for Login Page
            bundles.Add(new StyleBundle("~/Content/LoginCommonCSS").Include("~/css/bootstrap.min.css",
                "~/css/font-awesome.min.css",
                "~/css/smartadmin-production-plugins.min.css",
                "~/css/smartadmin-production.min.css",
                "~/css/smartadmin-skins.min.css",
                "~/css/smartadmin-rtl.min.css",
                "~/css/demo.min.css"));

            //Js for Login page
            bundles.Add(new ScriptBundle("~/bundles/LoginCommonJS").Include("~/Scripts/jquery-2.0.3.min.js",
                //"~/Scripts/jquery.validate.min.js",
                //"~/Scripts/jquery.validate.unobtrusive.min.js",
                 "~/assets/js/select2.min.js"));

            //CSS For Layout 
            bundles.Add(new StyleBundle("~/bundles/LayoutCommoncss").Include("~/assets/css/bootstrap.min.css",
                "~/assets/css/font-awesome.min.css",
                "~/assets/css/font-awesome-ie7.min.css",
                "~/assets/css/Icons.css",
                "~/assets/css/jquery.gritter.min.css",
                "~/assets/css/ace.min.css",
                "~/assets/css/ace-fonts.min.css",
                "~/assets/css/toastr.min.css",
                "~/assets/css/select2.min.css",
                "~/assets/css/jquery-ui.min.css",
                "~/assets/css/C9UserControl.css",
                "~/assets/css/ui.jqgrid.css",
                "~/assets/css/C9HelpControl.css",
                "~/assets/css/datepicker.min.css"));

            //js For Layout
            bundles.Add(new ScriptBundle("~/bundles/LayoutJS").Include("~/Scripts/jquery-2.0.3.min.js", 
                //"~/Scripts/jquery.validate.min.js",
                //"~/Scripts/jquery.validate.unobtrusive.min.js", 
                "~/Scripts/jquery.hotkeys-0.8.js",
                "~/assets/js/jquery-ui-1.10.3.full.min.js",
                "~/Scripts/bootstrap-typeahead.js",
                "~/Scripts/jQuery.hotKeyMap-1.0.js",
                "~/assets/js/dataTables/jquery.dataTables.js",
                "~/assets/js/ace-elements.min.js",
                "~/assets/js/bootstrap.min.js",
                "~/assets/js/bootbox.min.js",
                "~/assets/js/jquery.gritter.min.js",
                 "~/assets/js/ace.min.js",
                "~/assets/js/toastr.min.js",
                "~/assets/js/jquery.dataTables.bootstrap.js",
                "~/assets/js/select2.min.js",
                "~/Scripts/jquery.twbsPagination.js",
                "~/Scripts/jquery.tablesorter.min.js",
                "~/Scripts/nod.min.js",
                "~/assets/js/jquery.nestable.min.js",
                "~/assets/js/ProjectCommon.js", 
                "~/assets/js/date-time/bootstrap-datepicker_ver-8Dec2014.js",//bootstrap-datepicker.min.js
                "~/assets/js/jquery.maskedinput.min.js",
                "~/assets/js/C9UserControl.js",
                "~/assets/js/jqGrid/jquery.jqGrid.src.js",
                "~/assets/js/jquery.slimscroll.js",
                "~/assets/js/C9HelpControl.js"  
                //"~/Scripts/jquery.unobtrusive-ajax.js"
                ));
            
            BundleTable.EnableOptimizations = true;
        }
    }
}