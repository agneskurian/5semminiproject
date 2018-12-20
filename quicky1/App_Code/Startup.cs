using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quicky1.Startup))]
namespace quicky1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
