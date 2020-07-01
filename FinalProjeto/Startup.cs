using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProjeto.Startup))]
namespace FinalProjeto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
