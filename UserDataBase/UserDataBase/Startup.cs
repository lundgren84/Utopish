using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserDataBase.Startup))]
namespace UserDataBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
