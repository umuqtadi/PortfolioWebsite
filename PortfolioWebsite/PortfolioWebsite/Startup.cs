using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortfolioWebsite.Startup))]
namespace PortfolioWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
