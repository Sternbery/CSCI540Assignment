using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurveySays.Startup))]
namespace SurveySays
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
