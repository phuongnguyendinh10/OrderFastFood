using System.Threading.Tasks;
using Abp.Application.Services;
using OrderFastFoot.Authorization.Accounts.Dto;

namespace OrderFastFoot.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
