using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStoreScaffoling.Startup))]
namespace MVCStoreScaffoling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
