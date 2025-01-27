using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sumStore.Application.DTOs.Category;
using sumStore.Application.Services.Interfaces;

namespace sumStore.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAllCategories()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var categories = await categoryService.GetAllAsync();
            return categories.Count() > 0 ?
                                Ok(categories)
                                : NotFound(categories);
        }


        [HttpGet("single-category/{id}")]
        public async Task<IActionResult> GetSingleCategory(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var category = await categoryService.GetByIdAsync(id);
            return category != null ?
                                Ok(category)
                                : NotFound(category);
        }


        [HttpPost("add-category")]
        public async Task<IActionResult> Add(CreateCategory category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var response = await categoryService.AddAsync(category);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }


        [HttpPut("update-category")]
        public async Task<IActionResult> Update(UpdateCategory category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var response = await categoryService.UpdateAsync(category);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }


        [HttpDelete("delete-category/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var response = await categoryService.DeleteAsync(id);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
    }
}
