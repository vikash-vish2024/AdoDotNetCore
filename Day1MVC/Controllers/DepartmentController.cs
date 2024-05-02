using Day1MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace Day1MVC.Controllers
{
    public class DepartmentController : Controller
    {
        private static List<Department> Departmentlist = new List<Department>
        {
            new Department { DeptId = 1, DeptName = "IT", DeptDisciption="Infinite IT Team",DeptStregth = 100 },
            new Department { DeptId = 2, DeptName = "CSE", DeptDisciption="Infinite CSE Team",DeptStregth = 150 },
            new Department { DeptId = 3, DeptName = "AIDS", DeptDisciption="Infinite AIDS Team",DeptStregth = 200 },
            new Department { DeptId = 4, DeptName = "MECH", DeptDisciption="Infinite MECH Team",DeptStregth = 250 }
        };

        public IActionResult GetDepartment()
        {
            return View(Departmentlist);
        }

        public IActionResult AddDepartment([FromBody] Department dept)
        {
            Departmentlist.Add(dept);
            return RedirectToAction("~/View/Department/GetDepartment.cshtml");
        }
        public IActionResult GetDepartmentByBatchStrength()
        {
            var departmentData = (from department in Departmentlist
                                  where department.DeptStregth > 160
                                  select department).ToList();

            return View(departmentData);
        }
    }
}
