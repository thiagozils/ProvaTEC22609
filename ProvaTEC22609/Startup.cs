using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaTEC22609.Startup))]
namespace ProvaTEC22609
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
