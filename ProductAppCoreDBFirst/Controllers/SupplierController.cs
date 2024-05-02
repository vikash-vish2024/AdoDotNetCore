using Microsoft.AspNetCore.Mvc;
using ProductAppCoreDBFirst.Models;
using ProductAppCoreDBFirst.Repository;

namespace ProductAppCoreDBFirst.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = _supplierRepository;
        }
        public async Task<IActionResult> GetAllSupplier()
        {
            List<Supplier> suppliers = await _supplierRepository.GetAllSupplier();
            return View(suppliers);
        }

    }
}
