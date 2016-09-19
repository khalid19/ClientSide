using System.Web;
using System.Web.Mvc;

namespace Cr_Json_Obj_nd_Sh_in_Para_Jquery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
