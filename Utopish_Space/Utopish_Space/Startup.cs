using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Utopish_Space.Startup))]
namespace Utopish_Space
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
