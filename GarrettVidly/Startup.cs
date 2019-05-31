using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarrettVidly.Startup))]
namespace GarrettVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
