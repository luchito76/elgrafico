using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElGrafico.Startup))]
namespace ElGrafico
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
