using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caseding_Dropdown.Startup))]
namespace Caseding_Dropdown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
