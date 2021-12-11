using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDPSLibrary.Models
{
    /// <summary>
    /// Product class represent model of product.
    /// </summary>
    public class Product
    {
        [Key]
        public string Code { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        public MeasureUnit MeasureUnit { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
    public enum MeasureUnit
    {
        szt,
        kg,
        opk,
        l,
        m,
    }
}
