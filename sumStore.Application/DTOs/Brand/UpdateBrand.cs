using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Brand
{
    public class UpdateBrand : BrandBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
