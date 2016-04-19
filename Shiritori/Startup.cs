using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shiritori.Startup))]
namespace Shiritori
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
