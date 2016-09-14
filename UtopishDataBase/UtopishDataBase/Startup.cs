using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UtopishDataBase.Startup))]
namespace UtopishDataBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
