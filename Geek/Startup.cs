using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Geek.Startup))]
namespace Geek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
