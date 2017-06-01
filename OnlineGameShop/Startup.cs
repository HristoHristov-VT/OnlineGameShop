using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineGameShop.Startup))]
namespace OnlineGameShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
