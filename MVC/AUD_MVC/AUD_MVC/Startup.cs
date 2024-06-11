using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AUD_MVC.Startup))]
namespace AUD_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
