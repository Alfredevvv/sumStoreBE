
using sumStore.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.User
{
    public class UserBase
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public RoleType Role { get; set; }

    }
}
