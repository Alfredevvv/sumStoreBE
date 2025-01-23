using sumStore.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required RoleType Role { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}