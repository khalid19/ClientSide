using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cr_Json_Obj_nd_Sh_in_Para_Jquery.Controllers
{
    public class HomeController : Controller
    {   
        public class Employee
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }

        }

        public ActionResult Index()
        {
            return View();
        }



        public JsonResult Save(Employee employee)
        {
            return Json(employee,JsonRequestBehavior.AllowGet);
        }






        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}