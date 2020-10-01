using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asc3ndanceWebsite.Startup))]
namespace Asc3ndanceWebsite
{
    public partial class Bootup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
