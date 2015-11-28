using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealityJinak.Startup))]
namespace RealityJinak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
