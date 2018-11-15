using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppSecure.Startup))]
namespace AppSecure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
