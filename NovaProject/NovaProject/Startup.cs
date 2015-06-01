using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NovaProject.Startup))]
namespace NovaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
