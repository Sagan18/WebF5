using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebF5.Startup))]
namespace WebF5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
