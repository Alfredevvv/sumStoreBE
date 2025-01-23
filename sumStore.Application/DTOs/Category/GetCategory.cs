using sumStore.Application.DTOs.Product;

namespace sumStore.Application.DTOs.Category
{
    public class GetCategory
    {
        public Guid Id { get; set; }
        public ICollection<GetProduct>? Products { get; set; }
    }
}
