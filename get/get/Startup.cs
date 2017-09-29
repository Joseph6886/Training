using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(get.Startup))]
namespace get
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
