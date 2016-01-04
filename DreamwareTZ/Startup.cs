using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamwareTZ.Startup))]
namespace DreamwareTZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
