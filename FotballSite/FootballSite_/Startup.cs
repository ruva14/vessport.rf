using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballSite_.Startup))]
namespace FootballSite_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
