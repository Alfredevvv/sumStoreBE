using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sumStore.Application.DTOs.Review;
using sumStore.Application.Services.Interfaces;

namespace sumStore.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController(IReviewService reviewService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAllReviews()
        {
            var reviews = await reviewService.GetAllAsync();
            return reviews.Count() > 0 ?
                                Ok(reviews)
                                : NotFound(reviews);
        }
        [HttpGet("single-review/{id}")]
        public async Task<IActionResult> GetSingleReview(Guid id)
        {
            var review = await reviewService.GetByIdAsync(id);
            return review != null ?
                                Ok(review)
                                : NotFound(review);
        }
        [HttpPost("add-review")]
        public async Task<IActionResult> Add(CreateReview review)
        {
            var response = await reviewService.AddAsync(review);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
        [HttpPut("update-review")]
        public async Task<IActionResult> Update(UpdateReview review)
        {
            var response = await reviewService.UpdateAsync(review);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
        [HttpDelete("delete-review/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await reviewService.DeleteAsync(id);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
    }
}
