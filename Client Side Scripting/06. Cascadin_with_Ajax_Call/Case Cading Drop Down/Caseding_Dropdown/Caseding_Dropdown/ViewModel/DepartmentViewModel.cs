using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Caseding_Dropdown.Models;

namespace Caseding_Dropdown.ViewModel
{
    public class DepartmentViewModel:Department
    {

        List<Department> departments = new List<Department>
            {
                new Department(){DepartmentId = 1,Code = "CSE"},
                new Department(){DepartmentId = 2,Code = "ISE"},
                new Department(){DepartmentId = 3,Code = "EEE"}
            };
       public virtual IEnumerable<SelectListItem> DepartmentSelectListItem
        {
            get {return new SelectList(departments,"DepartmentId","Code");}
        } 
         
    } 
}

