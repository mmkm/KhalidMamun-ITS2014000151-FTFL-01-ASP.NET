using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(countryCity_exam.Startup))]
namespace countryCity_exam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
