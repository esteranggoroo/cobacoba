using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cobacoba.Startup))]
namespace cobacoba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
