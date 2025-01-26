using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Product
{
    public class ProductBase
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public List<string>? ImageUrls { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public Guid BrandId { get; set; } 
    }
}
