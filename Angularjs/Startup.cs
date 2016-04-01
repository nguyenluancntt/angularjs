using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angularjs.Startup))]
namespace Angularjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
