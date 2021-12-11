using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDPSLibrary.Models
{
    /// <summary>
    /// Class represent product relation many to many with Invoice
    /// </summary>
    public class ProductsOnInvoice
    {
        [Key]
        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        [ForeignKey("InvoiceNumber")]
        public Invoice Invoice { get; set; }
        public string ProductCode { get; set; }
        [ForeignKey("ProductCode")]
        public Product Product { get; set; }
        [Required]
        public float QuantityOfProduct { get; set; }
    }
}
