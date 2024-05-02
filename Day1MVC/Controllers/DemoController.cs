using Day1MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DisplayEmployee()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Test";
            employee.Email = "Test";
            return Json(employee);
        }

        public ViewResult DisplayName() { return View(); }
    }
}
