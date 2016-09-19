using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Form_Serialize.Startup))]
namespace Form_Serialize
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
