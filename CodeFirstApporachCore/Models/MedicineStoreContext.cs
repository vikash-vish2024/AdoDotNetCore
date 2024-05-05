using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CodeFirstApporachCore.Models
{
    public class MedicineStoreContext : DbContext
    {
        public MedicineStoreContext(DbContextOptions<MedicineStoreContext> options) : base(options)
        {
            
        }
        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<CodeFirstApporachCore.Models.MedicineSupplier> MedicineSupplier { get; set; } = default!;
        public DbSet<MedsDescription> medsDescriptions { get; set; }
    }
}
