using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTA_Classwork.Startup))]
namespace MTA_Classwork
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
