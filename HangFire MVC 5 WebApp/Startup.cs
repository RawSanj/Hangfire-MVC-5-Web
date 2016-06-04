using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HangFire_MVC_5_WebApp.Startup))]
namespace HangFire_MVC_5_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
