using System.ComponentModel.DataAnnotations;

namespace sumStore.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
