using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebApplication2.Startup))]
namespace TestWebApplication2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
