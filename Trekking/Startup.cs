using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trekking.Startup))]
namespace Trekking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
