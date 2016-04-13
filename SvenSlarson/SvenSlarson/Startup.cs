using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SvenSlarson.Startup))]
namespace SvenSlarson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
