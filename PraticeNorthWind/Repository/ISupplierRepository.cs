using PraticeNorthWind.Models;
namespace PraticeNorthWind.Repository
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllSupplier();
        Supplier AddSupplier(Supplier supplier);
        Supplier GetSupplierByCompanyName(string companyName);
        Supplier EditSupplier(Supplier supplier);
        void DeleteSupplier(int supplierId);
    }
}
