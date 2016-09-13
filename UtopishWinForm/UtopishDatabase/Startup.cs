using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UtopishDatabase.Startup))]
namespace UtopishDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
