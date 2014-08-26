using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelPassingFromControllerToPartialView.Startup))]
namespace ModelPassingFromControllerToPartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
