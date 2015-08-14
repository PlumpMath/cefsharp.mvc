using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cefsharp.mvc.Startup))]
namespace cefsharp.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
