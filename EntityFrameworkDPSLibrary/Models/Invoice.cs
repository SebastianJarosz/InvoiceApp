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
        public DateTime CreationTime { get; set; }
        public DateTime ModyficationTime { get; set; }
        public string BuyerNIP { get; set; }
        public string SellerNIP { get; set; }

    }
}
