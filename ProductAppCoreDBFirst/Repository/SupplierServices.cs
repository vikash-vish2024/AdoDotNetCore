using Microsoft.EntityFrameworkCore;
using ProductAppCoreDBFirst.Models;

namespace ProductAppCoreDBFirst.Repository
{
    public class SupplierServices : ISupplierRepository
    {
        private readonly NorthwindContext _context;
        public SupplierServices(NorthwindContext context)
        {
            _context = context;
        }
        public async  Task<List<Supplier>> GetAllSupplier()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier> GetSupplierById(int id)
        {
            Supplier supplier= await _context.Suppliers.FindAsync(id);
            return supplier;
        }

    }
}
