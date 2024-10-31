using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuHoaiNam.Startup))]
namespace VuHoaiNam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
