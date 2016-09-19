using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cr_Json_Obj_nd_Sh_in_Para_Jquery.Startup))]
namespace Cr_Json_Obj_nd_Sh_in_Para_Jquery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
