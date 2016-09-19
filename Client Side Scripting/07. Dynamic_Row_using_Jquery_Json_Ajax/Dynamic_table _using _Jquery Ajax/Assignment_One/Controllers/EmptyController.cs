using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_One.Controllers
{
   public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
    public class EmptyController : Controller
    {
        //
        // GET: /Empty/
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Save(Employee employee)
        {

            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveList(List<Employee> employees)
        {
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

	}
}