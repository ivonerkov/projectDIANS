using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectDians.Startup))]
namespace ProjectDians
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
