using Microsoft.EntityFrameworkCore;
using PraticeNorthWind.Models;

namespace PraticeNorthWind.Repository
{
    public class SupplierService: ISupplierRepository
    {
        private readonly NorthwindContext _context;

        public SupplierService(NorthwindContext context)
        {
            _context = context;
        }

        public Task<List<Supplier>> GetAllSupplier()
        {
            return _context.Suppliers.ToListAsync();
        }
        public Supplier AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public Supplier GetSupplierByCompanyName(string companyName)
        {
            return _context.Suppliers.FirstOrDefault(s => s.CompanyName == companyName);
        }

        public Supplier EditSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public void DeleteSupplier(int supplierId)
        {
            var supplier = _context.Suppliers.Find(supplierId);
            if (supplier != null)
            {
                supplier.isDeleted = true;
                _context.SaveChanges();
            }
        }

        
    }
}
