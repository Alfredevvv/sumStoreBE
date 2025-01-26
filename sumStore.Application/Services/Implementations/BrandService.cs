using AutoMapper;
using sumStore.Application.DTOs;
using sumStore.Application.DTOs.Brand;
using sumStore.Application.Services.Interfaces;
using sumStore.Domain.Entities;
using sumStore.Domain.Interfaces;

namespace sumStore.Application.Services.Implementations
{
    public class BrandService(IGeneric<Brand> brandInterface, IMapper _mapper) : IBrandService
    {
        public async Task<ServiceResponse> AddAsync(CreateBrand brand)
        {
            var mappedData = _mapper.Map<Brand>(brand);
            int result = await brandInterface.AddAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Brand added successfully")
                : new ServiceResponse(false, "Brand failed to be added");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await brandInterface.DeleteAsync(id);
            if (result == 0)
                return new ServiceResponse(false, "Brand not found");
            return result > 0 ? new ServiceResponse(true, "Brand deleted successfully")
                : new ServiceResponse(false, "Brand delete HAS FAILED");
            
        }

        public async Task<IEnumerable<GetBrand>> GetAllAsync()
        {
            var rawData = await brandInterface.GetAllAsync();
            if (!rawData.Any())
                return [];
            return _mapper.Map<IEnumerable<GetBrand>>(rawData);
            
        }

        public async Task<GetBrand> GetByIdAsync(Guid id)
        {
            var rawData = await brandInterface.GetByIdAsync(id);
            if (rawData == null)
                return new GetBrand();
            return _mapper.Map<GetBrand>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateBrand brand)
        {
            var mappedData = _mapper.Map<Brand>(brand);
            int result = await brandInterface.UpdateAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Brand updated successfully")
                : new ServiceResponse(false, "Brand failed to be updated");
        }
    }
}
