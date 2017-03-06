using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blockbuster.Startup))]
namespace Blockbuster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
