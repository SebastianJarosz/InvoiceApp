using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDPSLibrary.Models
{
    /// <summary>
    /// Seller class for invoice
    /// </summary>
    public class Seller
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
