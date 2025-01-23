namespace sumStore.Application.DTOs.Product
{
    public class ProductBase
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<string>? ImageUrls { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; } 
    }
}
