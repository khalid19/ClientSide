using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Caseding_Dropdown.Models;
using Caseding_Dropdown.ViewModel;
using Microsoft.Ajax.Utilities;

namespace Caseding_Dropdown.Controllers
{

    public class Student:Department
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }

    public class HomeController : Controller
    {
        
        public ActionResult Index(DepartmentViewModel model)
        {   
            return View(model);
        }



        public ActionResult GetStudents(int departmentId)
        {
            List<Student> students = new List<Student>
            {
                new Student(){DepartmentId = 1, StudentId = 1, Name = "Mahade1",Address = "Dhaka"},
                new Student(){DepartmentId = 1, StudentId = 1, Name = "Mahade1",Address = "Dhaka"},
                new Student(){DepartmentId = 2, StudentId = 1, Name = "Mahade2",Address = "Dhaka"},
                new Student(){DepartmentId = 2, StudentId = 1, Name = "Mahade2",Address = "Dhaka"},
                new Student(){DepartmentId = 3, StudentId = 1, Name = "Mahade3",Address = "Dhaka"},
                new Student(){DepartmentId = 3, StudentId = 1, Name = "Mahade3",Address = "Dhaka"},
            };
            students = students.Where(x => x.DepartmentId == departmentId).ToList();
            return View( "GetStudent",students);

        }

    }
}