using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoNova.Startup))]
namespace ProjetoNova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
