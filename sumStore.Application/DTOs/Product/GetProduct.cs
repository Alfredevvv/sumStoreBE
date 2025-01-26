using sumStore.Application.DTOs.Brand;
using sumStore.Application.DTOs.Category;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Product
{
    public class GetProduct : ProductBase
    {
        [Required]
        public Guid Id { get; set; }
        public GetCategory? Category { get; set; }
        public GetBrand? Brand { get; set; }
    }
}
