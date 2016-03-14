using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NPoco.Identity.Provider.Website.Startup))]
namespace NPoco.Identity.Provider.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
