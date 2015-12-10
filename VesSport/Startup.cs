using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VesSport.Startup))]
namespace VesSport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
