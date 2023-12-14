using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCDMIS.Startup))]
namespace NCDMIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
