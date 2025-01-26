
using sumStore.Application.DTOs;
using sumStore.Application.DTOs.Review;

namespace sumStore.Application.Services.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<GetReview>> GetAllAsync();
        Task<GetReview> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateReview review);
        Task<ServiceResponse> UpdateAsync(UpdateReview review);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
