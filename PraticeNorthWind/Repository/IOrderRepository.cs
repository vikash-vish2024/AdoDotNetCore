using PraticeNorthWind.Models;

namespace PraticeNorthWind.Repository
{
    public interface IOrderRepository
    {
        List<CustOrdersOrders> GetCustOrdersOrders(string Customerid);
    }
}
