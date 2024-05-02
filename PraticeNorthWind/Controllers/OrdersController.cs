using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraticeNorthWind.Models;

namespace PraticeNorthWind.Controllers
{
    public class OrdersController : Controller
    {
        private NorthwindContext _context=new NorthwindContext();   
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetOrder(string custid)
        {
            List<CustOrdersOrders> odr= _context.CustOrdersOrders.FromSqlInterpolated($"CustOrdersOrders @Customerid = {custid}").ToList();
            return View(odr);
        }

        public List<Order> GetAllOrder()
        {
            return _context.Orders.ToList();
        }
    }
}
