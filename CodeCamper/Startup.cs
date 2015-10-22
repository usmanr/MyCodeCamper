using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeCamper.Startup))]
namespace CodeCamper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
