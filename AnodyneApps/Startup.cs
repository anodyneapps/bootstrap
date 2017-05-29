using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnodyneApps.Startup))]
namespace AnodyneApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
