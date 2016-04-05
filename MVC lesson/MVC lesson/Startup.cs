using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_lesson.Startup))]
namespace MVC_lesson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
