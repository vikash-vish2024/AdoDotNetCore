using Microsoft.EntityFrameworkCore;
using NorthWindDB.Models;

namespace NorthWindDB.Repository
{
    public class SupplierServices : ISupplierRepository
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierServices(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public Supplier AddSupplier(Supplier supplier)
        {
            return _supplierRepository.AddSupplier(supplier);
        }

        public Supplier EditSupplier(Supplier supplier)
        {
            return _supplierRepository.EditSupplier(supplier);
        }

        public void DeleteSupplier(int supplierId)
        {
            _supplierRepository.DeleteSupplier(supplierId);
        }

        public Task<List<Supplier>> GetAllSupplier()
        {
            throw new NotImplementedException();
        }
    }
}
