using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School.UI.SistemaMatricula.Startup))]
namespace School.UI.SistemaMatricula
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
