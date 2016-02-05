using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameChanger.Startup))]
namespace GameChanger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
