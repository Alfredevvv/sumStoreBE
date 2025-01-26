
using sumStore.Application.DTOs.Product;
using sumStore.Application.DTOs.User;
using System.ComponentModel.DataAnnotations;

namespace sumStore.Application.DTOs.Review
{
    public class GetReview : ReviewBase
    {
        [Required]
        public Guid Id { get; set; }
        public GetProduct? Product { get; set; }
        //Pending to add GetUser prop 
        public GetUser? User { get; set; }
    }
}
