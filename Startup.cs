using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFPT.Startup))]
namespace MVCFPT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
