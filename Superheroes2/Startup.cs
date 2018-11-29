using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Superheroes2.Startup))]
namespace Superheroes2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
