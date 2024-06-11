using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoursesKolokviumska.Startup))]
namespace CoursesKolokviumska
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
