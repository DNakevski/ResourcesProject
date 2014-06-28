using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResourcesProject.Startup))]
namespace ResourcesProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
