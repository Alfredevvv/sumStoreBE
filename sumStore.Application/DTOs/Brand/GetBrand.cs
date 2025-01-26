using sumStore.Application.DTOs.Product;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Brand
{
    public class GetBrand : BrandBase
    {
        [Required]
        public Guid Id { get; set; }
        public ICollection<GetProduct>? Products { get; set; }
    }
}
