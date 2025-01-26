using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Review
{
    public class UpdateReview : ReviewBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
