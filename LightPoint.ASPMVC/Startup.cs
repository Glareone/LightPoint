using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LightPoint.ASPMVC.Startup))]
namespace LightPoint.ASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
