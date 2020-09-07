using BIC_Payroll.App_Start;
using BIC_Payroll.Filters;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BIC_Payroll
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
             
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalFilters.Filters.Add(new CustomExceptionAttribute());
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
