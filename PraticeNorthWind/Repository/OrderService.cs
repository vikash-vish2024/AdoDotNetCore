using Microsoft.EntityFrameworkCore;
using PraticeNorthWind.Models;

namespace PraticeNorthWind.Repository
{
    public class OrderService : IOrderRepository
    {
        private readonly NorthwindContext context;

        public OrderService(NorthwindContext context)
        {
            this.context = context;
        }
        public List<CustOrdersOrders> GetCustOrdersOrders(string Customerid)
        {
            List<CustOrdersOrders> orders = context.CustOrdersOrders.FromSqlInterpolated($"CustOrdersOrders @Customerid = {Customerid}").ToList();
            return orders;
        }

        //List<CustOrdersOrders> IOrderRepository.GetCustOrdersOrders(string Customerid)
        //{
        //    List<CustOrdersOrders> orders = context.CustOrdersOrders.FromSqlInterpolated($"CustOrdersOrders @Customerid = {Customerid}").ToList();
        //    return orders;
        //}
    }
}
