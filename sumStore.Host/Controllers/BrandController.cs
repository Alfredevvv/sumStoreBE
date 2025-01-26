using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sumStore.Application.DTOs.Brand;
using sumStore.Application.Services.Interfaces;

namespace sumStore.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController(IBrandService brandService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAllBrands()
        {
            var brands = await brandService.GetAllAsync();
            return brands.Count() > 0 ?
                                Ok(brands)
                                : NotFound(brands);
        }
        [HttpGet("single-brand/{id}")]
        public async Task<IActionResult> GetSingleBrand(Guid id)
        {
            var brand = await brandService.GetByIdAsync(id);
            return brand != null ?
                                Ok(brand)
                                : NotFound(brand);
        }
        [HttpPost("add-brand")]
        public async Task<IActionResult> Add(CreateBrand brand)
        {
            var response = await brandService.AddAsync(brand);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
        [HttpPut("update-brand")]
        public async Task<IActionResult> Update(UpdateBrand brand)
        {
            var response = await brandService.UpdateAsync(brand);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
        [HttpDelete("delete-brand/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await brandService.DeleteAsync(id);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
    }
}
