using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnidaysTestAhmedAhmed.Startup))]
namespace UnidaysTestAhmedAhmed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
