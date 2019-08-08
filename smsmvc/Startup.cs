using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smsmvc.Startup))]
namespace smsmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
