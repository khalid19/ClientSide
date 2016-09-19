using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Form_Serialize.Models;

namespace Form_Serialize.Controllers
{
    public class HomeController : Controller
    {    
        public ActionResult Index()
        {
           return View();
        }





        public JsonResult Save(Student student)
        {
            return Json(student, JsonRequestBehavior.AllowGet);
        }

        







    }
}