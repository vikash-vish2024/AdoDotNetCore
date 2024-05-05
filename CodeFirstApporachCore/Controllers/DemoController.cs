using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApporachCore.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            int num1=20,num2=0, result; 
            result=num1 / num2;
            return View();
        }

 
        public IActionResult CustomError()
        {
            return View();
        }
    }
}
