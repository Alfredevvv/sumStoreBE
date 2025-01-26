using AutoMapper;
using sumStore.Application.DTOs;
using sumStore.Application.DTOs.Review;
using sumStore.Application.Services.Interfaces;
using sumStore.Domain.Entities;
using sumStore.Domain.Interfaces;

namespace sumStore.Application.Services.Implementations
{
    public class ReviewService(IGeneric<Review> reviewInterface, IMapper _mapper) : IReviewService
    {
        public async Task<ServiceResponse> AddAsync(CreateReview review)
        {
           var mappedData = _mapper.Map<Review>(review);
            int result = await reviewInterface.AddAsync(mappedData);

            return result > 0 ? new ServiceResponse(true, "Review added successfully")
                : new ServiceResponse(false, "Review failed to be added");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            var result = await reviewInterface.DeleteAsync(id);
            if (result == 0)
                return new ServiceResponse(false, "Review not found");
            return result > 0 ? new ServiceResponse(true, "Review deleted successfully")
                : new ServiceResponse(false, "Review delete HAS FAILED");
        }

        public async Task<IEnumerable<GetReview>> GetAllAsync()
        {
            var rawData = await reviewInterface.GetAllAsync();
            if (!rawData.Any())
                return [];
            return _mapper.Map<IEnumerable<GetReview>>(rawData);
        }

        public async Task<GetReview> GetByIdAsync(Guid id)
        {
            var rawData = await reviewInterface.GetByIdAsync(id);
            if (rawData == null)
                return new GetReview();
            return _mapper.Map<GetReview>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateReview review)
        {
            var mappedData = _mapper.Map<Review>(review);
            int result = await reviewInterface.UpdateAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Review added successfully")
                : new ServiceResponse(false, "Review failed to be added");
        }
    }
}
