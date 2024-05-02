using NorthWindDB.Models;

namespace NorthWindDB.Repository
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllSupplier();
        Supplier AddSupplier(Supplier supplier);
        Supplier EditSupplier(Supplier supplier);
        void DeleteSupplier(int supplierId);
    }
}
