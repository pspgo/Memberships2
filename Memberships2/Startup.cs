using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Memberships2.Startup))]
namespace Memberships2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
