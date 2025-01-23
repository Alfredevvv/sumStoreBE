using sumStore.Application.DTOs.Brand;
using sumStore.Application.DTOs.Category;

namespace sumStore.Application.DTOs.Product
{
    public class GetProduct : ProductBase
    {
        public Guid Id { get; set; }
        public GetCategory? Category { get; set; }
        public GetBrand? Brand { get; set; }
    }
}
