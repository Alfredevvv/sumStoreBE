using System.ComponentModel.DataAnnotations;

namespace sumStore.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public required string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<string>? ImageUrls { get; set; }
        public Guid BrandId { get; set; }
        public required Brand Brand { get; set; }
        public required Category Category { get; set; }
        public Guid CategoryId { get; set; }

        //public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        //Reviews and Ratings
        public List<Review> Reviews { get; set; } = new List<Review>();
        public decimal Rating { get; set; }
        public int TotalRatings { get; set; }

    }
}
