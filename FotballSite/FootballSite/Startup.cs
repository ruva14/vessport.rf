using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballSite.Startup))]
namespace FootballSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
