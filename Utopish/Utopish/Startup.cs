using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Utopish.Startup))]
namespace Utopish
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
