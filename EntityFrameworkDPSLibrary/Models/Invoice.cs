using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDPSLibrary.Models
{
    /// <summary>
    /// Invoice class represent model of invoice.
    /// </summary>
    public class Invoice
    {
        [Key]
        public string InvoiceNumber { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        [Required]
        public DateTime ModyficationTime { get; set; }
        [Required]
        public string BuyerNIP { get; set; }
        [Required]
        public string SellerNIP { get; set; }

    }
}
