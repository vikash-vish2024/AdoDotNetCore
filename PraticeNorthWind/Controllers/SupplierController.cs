using Microsoft.AspNetCore.Mvc;
using PraticeNorthWind.Repository;

namespace PraticeNorthWind.Controllers
{
    public class SupplierController : Controller
    {
        private  ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplieryRepository)
        {
            _supplierRepository = supplieryRepository;
        }
        public IActionResult GetAllSupplier()
        {
            return View( _supplierRepository.GetAllSupplier());
        }
    }
}
