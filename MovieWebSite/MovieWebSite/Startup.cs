using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieWebSite.Startup))]
namespace MovieWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
