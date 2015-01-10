using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPB.Startup))]
namespace SPB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
