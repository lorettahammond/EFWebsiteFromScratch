using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LLHManufacturing.Startup))]
namespace LLHManufacturing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
