using AutoMapper;
using sumStore.Application.DTOs;
using sumStore.Application.DTOs.Product;
using sumStore.Application.Services.Interfaces;
using sumStore.Domain.Entities;
using sumStore.Domain.Interfaces;

namespace sumStore.Application.Services.Implementations
{
    public class ProductService(IGeneric<Product> productInterface, IMapper _mapper) : IProductService
    {
        public async Task<ServiceResponse> AddAsync(CreateProduct product)
        {
            var mappedData = _mapper.Map<Product>(product);
            int result = await productInterface.AddAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Product added successfully")
                : new ServiceResponse(false, "Product failed to be added");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await productInterface.DeleteAsync(id);
            if (result == 0)
                return new ServiceResponse(false, "Product not found");
            return result > 0 ? new ServiceResponse(true, "Product deleted successfully") 
                : new ServiceResponse(false, "Product delete HAS FAILED");
        }

        public async Task<IEnumerable<GetProduct>> GetAllAsync()
        {
            var rawData = await productInterface.GetAllAsync();
            if (!rawData.Any()) 
                return [];
            return _mapper.Map<IEnumerable<GetProduct>>(rawData);
        }

        public async Task<GetProduct> GetByIdAsync(Guid id)
        {
            var rawData = await productInterface.GetByIdAsync(id);
            if (rawData == null)
                return new GetProduct();
            return _mapper.Map<GetProduct>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateProduct product)
        {
            var mappedData = _mapper.Map<Product>(product);
            int result = await productInterface.UpdateAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Product updated successfully")
                : new ServiceResponse(false, "Product failed to be updated");
        }
    }
}
