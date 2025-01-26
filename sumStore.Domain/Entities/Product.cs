using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sumStore.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public required string? Name { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        public Guid BrandId { get; set; }
        public required Brand Brand { get; set; }
        public required Category Category { get; set; }
        public Guid CategoryId { get; set; }

        //public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        //Reviews and Ratings
        public List<Review> Reviews { get; set; } = new List<Review>();
        
        [Column(TypeName = "decimal(18,3)")]
        public decimal Rating { get; set; }
        public int TotalRatings { get; set; }

    }
}
