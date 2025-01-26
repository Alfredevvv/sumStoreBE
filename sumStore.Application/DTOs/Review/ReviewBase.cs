using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Review
{
    public class ReviewBase
    {
        [Required]
        public string? Title { get; set; }

        public string? Comment { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid ProductId { get; set; }
    }
}
