using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NovaProjecWF.Startup))]
namespace NovaProjecWF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
