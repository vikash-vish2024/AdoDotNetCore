using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CodeFirstApporachCore.Models
{
    public class MedicineSupplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public string ContactDetails { get; set; }


        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}