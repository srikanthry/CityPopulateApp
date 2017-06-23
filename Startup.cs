using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CityPopulateApp.Startup))]
namespace CityPopulateApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
