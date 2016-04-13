using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeIsStrange.Startup))]
namespace LifeIsStrange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
