using Microsoft.AspNetCore.Mvc;
using PraticeNorthWind.Repository;

namespace PraticeNorthWind.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository ordersRepository;
        public OrderController(IOrderRepository ordersRepository)
        {

            this.ordersRepository = ordersRepository;
        }

        public IActionResult CallProcedurewithParameter()
        {
            return View(ordersRepository.GetCustOrdersOrders("VINET"));
        }
    }
}
