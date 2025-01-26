using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Category
{
    public class CategoryBase
    {
        [Required]
        public string? Name { get; set; }
    }
}
