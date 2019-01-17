using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTender.Startup))]
namespace WebTender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
