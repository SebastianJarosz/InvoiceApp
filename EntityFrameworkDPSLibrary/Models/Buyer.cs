using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDPSLibrary.Models
{
    /// <summary>
    /// Buyer class represent model of buyer for Invoice
    /// </summary>
    public class Buyer
    {
        [Key]
        [MaxLength(10)]
        public string NIP { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string StreetNumber { get; set; }
        public Nullable<int> FlatNumber { get; set; }
    }
}
