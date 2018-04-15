using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunFarma.Web.Startup))]
namespace SunFarma.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
