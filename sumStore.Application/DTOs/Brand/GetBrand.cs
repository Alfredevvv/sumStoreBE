using sumStore.Application.DTOs.Product;

namespace sumStore.Application.DTOs.Brand
{
    public class GetBrand
    {
        public Guid Id { get; set; }
        public ICollection<GetProduct>? Products { get; set; }
    }
}
