using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Category
{
    public class UpdateCategory : CategoryBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
