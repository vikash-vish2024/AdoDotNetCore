using ProductAppCoreDBFirst.Models;

namespace ProductAppCoreDBFirst.Repository
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllSupplier();
        Task<Supplier> GetSupplierById(int id);

    }
}
