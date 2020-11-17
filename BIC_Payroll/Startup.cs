using BIC_Payroll;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace BIC_Payroll
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var hubConfiguration = new HubConfiguration();
            //hubConfiguration.EnableDetailedErrors = true;
            //app.MapSignalR();
        }
    }
}