using System.ComponentModel.DataAnnotations;
namespace sumStore.Application.DTOs.Product
{
    public class UpdateProduct : ProductBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
