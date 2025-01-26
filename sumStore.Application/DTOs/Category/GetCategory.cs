using sumStore.Application.DTOs.Product;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Category
{
    public class GetCategory : CategoryBase
    {
        [Required]
        public Guid Id { get; set; }
        public ICollection<GetProduct>? Products { get; set; }
    }
}
