using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublistTestWeb.Startup))]
namespace PublistTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
