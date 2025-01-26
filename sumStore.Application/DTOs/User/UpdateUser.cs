using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.User
{
    public class UpdateUser : UserBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
