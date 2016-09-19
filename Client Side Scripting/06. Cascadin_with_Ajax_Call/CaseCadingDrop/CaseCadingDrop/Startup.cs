using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaseCadingDrop.Startup))]
namespace CaseCadingDrop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
