using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OrderFastFood.Roles.Dto;
using OrderFastFood.Users.Dto;

namespace OrderFastFood.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}