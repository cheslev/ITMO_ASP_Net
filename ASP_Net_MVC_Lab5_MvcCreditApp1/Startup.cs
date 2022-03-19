using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Net_MVC_Lab5_MvcCreditApp1.Startup))]
namespace ASP_Net_MVC_Lab5_MvcCreditApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
