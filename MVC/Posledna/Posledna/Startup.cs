using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Posledna.Startup))]
namespace Posledna
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
