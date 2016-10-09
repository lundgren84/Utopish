using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountDataBase.Startup))]
namespace AccountDataBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
