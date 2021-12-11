using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDPSLibrary.Models
{
    public class DailyInvoiceCounter
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public int Count { get; set; }
    }
}
