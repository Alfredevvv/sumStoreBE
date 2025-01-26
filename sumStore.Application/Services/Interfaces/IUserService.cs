
using sumStore.Application.DTOs;
using sumStore.Application.DTOs.User;

namespace sumStore.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<GetUser>> GetAllAsync();
        Task<GetUser> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateUser user);
        Task<ServiceResponse> UpdateAsync(UpdateUser user);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
