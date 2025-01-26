using AutoMapper;
using sumStore.Application.DTOs;
using sumStore.Application.DTOs.Category;
using sumStore.Application.Services.Interfaces;
using sumStore.Domain.Entities;
using sumStore.Domain.Interfaces;

namespace sumStore.Application.Services.Implementations
{
    public class CategoryService(IGeneric<Category> categoryInterface, IMapper _mapper) : ICategoryService
    {
        public async Task<ServiceResponse> AddAsync(CreateCategory category)
        {
            var mappedData = _mapper.Map<Category>(category);
            int result = await categoryInterface.AddAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Category added successfully")
                : new ServiceResponse(false, "Category failed to be added");
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            int result = await categoryInterface.DeleteAsync(id);
            if (result == 0)
                return new ServiceResponse(false, "Category not found");
            return result > 0 ? new ServiceResponse(true, "Category deleted successfully")
                : new ServiceResponse(false, "Category delete HAS FAILED");
        }

        public async Task<IEnumerable<GetCategory>> GetAllAsync()
        {
            var rawData = await categoryInterface.GetAllAsync();
            if (!rawData.Any())
                return [];
            return _mapper.Map<IEnumerable<GetCategory>>(rawData);
        }

        public async Task<GetCategory> GetByIdAsync(Guid id)
        {
            var rawData = await categoryInterface.GetByIdAsync(id);
            if (rawData == null)
                return new GetCategory();
            return _mapper.Map<GetCategory>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateCategory category)
        {
            var mappedData = _mapper.Map<Category>(category);
            int result = await categoryInterface.UpdateAsync(mappedData);
            return result > 0 ? new ServiceResponse(true, "Category added successfully")
                : new ServiceResponse(false, "Category failed to be added");
        }
    }
}
