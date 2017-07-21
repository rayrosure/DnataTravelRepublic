using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dnata.TravelRepublic.Startup))]
namespace Dnata.TravelRepublic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
