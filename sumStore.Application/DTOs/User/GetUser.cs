using sumStore.Application.DTOs.Review;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.User
{
    public class GetUser : UserBase
    {
        [Required]
        public Guid Id { get; set; }
        public ICollection<GetReview>? Reviews { get; set; }
    }
}
