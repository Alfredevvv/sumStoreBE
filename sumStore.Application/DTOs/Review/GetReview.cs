
using sumStore.Application.DTOs.Product;

namespace sumStore.Application.DTOs.Review
{
    public class GetReview
    {
        public Guid Id { get; set; }
        public GetProduct? Product { get; set; }
        //Pending to add GetUser prop 
    }
}
