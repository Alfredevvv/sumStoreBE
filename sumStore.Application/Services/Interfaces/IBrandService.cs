using sumStore.Application.DTOs;
using sumStore.Application.DTOs.Brand;

namespace sumStore.Application.Services.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<GetBrand>> GetAllAsync();
        Task<GetBrand> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateBrand brand);
        Task<ServiceResponse> UpdateAsync(UpdateBrand brand);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
