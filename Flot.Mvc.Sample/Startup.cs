using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flot.Mvc.Sample.Startup))]
namespace Flot.Mvc.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);
        }
    }
}
