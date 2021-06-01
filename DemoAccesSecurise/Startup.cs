using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAccesSecurise.Startup))]
namespace DemoAccesSecurise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
