using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThemeChange.Startup))]
namespace ThemeChange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
