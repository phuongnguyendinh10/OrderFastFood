using System.Threading.Tasks;
using Abp.Application.Services;
using OrderFastFood.Sessions.Dto;

namespace OrderFastFood.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
