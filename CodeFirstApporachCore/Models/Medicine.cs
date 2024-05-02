﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CodeFirstApporachCore.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineDescription { get; set; }

        public decimal MedicinePrice { get; set; }

        public int Quantity { get; set; }

        [JsonIgnore]
        public virtual MedicineSupplier MedicineSupplier { get; set; }

    }
}
