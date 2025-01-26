
using System.ComponentModel.DataAnnotations;

namespace sumStore.Domain.Entities
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public required Product Product { get; set; }
        //public Guid UserId { get; set; }
        //public required User User { get; set; }
        public required string Title { get; set; }
        public string? Comment { get; set; }
        public required int Rating { get; set; }
    }
}
