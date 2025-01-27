using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sumStore.Application.DTOs.Product;
using sumStore.Application.Services.Interfaces;

namespace sumStore.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAllProducts()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var products = await productService.GetAllAsync();
            return products.Count() > 0 ? 
                                Ok(products) 
                                : NotFound(products);
        }

        [HttpGet("single-product/{id}")]
        public async Task<IActionResult> GetSingleProduct(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var product = await productService.GetByIdAsync(id);
            return product != null ?
                                Ok(product)
                                : NotFound(product);
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> Add(CreateProduct product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var response = await productService.AddAsync(product);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }

        [HttpPut("update-product")]
        public async Task<IActionResult> Update(UpdateProduct product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var response = await productService.UpdateAsync(product);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }

        [HttpDelete("delete-product/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var response = await productService.DeleteAsync(id);
            return response.Success ?
                                Ok(response)
                                : BadRequest(response);
        }
    }
}
