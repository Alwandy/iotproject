using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIOTCA3.Startup))]
namespace AIOTCA3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
