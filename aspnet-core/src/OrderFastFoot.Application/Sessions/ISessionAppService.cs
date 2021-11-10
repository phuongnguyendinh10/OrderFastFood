using System.Threading.Tasks;
using Abp.Application.Services;
using OrderFastFoot.Sessions.Dto;

namespace OrderFastFoot.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
