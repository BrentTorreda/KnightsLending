using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnightsLending.Startup))]
namespace KnightsLending
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
