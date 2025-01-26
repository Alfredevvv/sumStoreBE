using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Brand
{
    public class BrandBase
    {
        [Required]
        public string? Name { get; set; }
    }
}
