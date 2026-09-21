using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PawPort.Startup))]
namespace PawPort
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
