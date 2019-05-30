using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaticMVC.Startup))]
namespace StaticMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
