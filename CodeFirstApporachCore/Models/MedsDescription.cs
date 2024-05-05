using System.ComponentModel.DataAnnotations;

namespace CodeFirstApporachCore.Models
{
    public class MedsDescription
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string ManufacturingDate { get; set; }
        public string ExpiryDate { get; set; }


    }
}
