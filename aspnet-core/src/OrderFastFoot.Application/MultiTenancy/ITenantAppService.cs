using Abp.Application.Services;
using OrderFastFoot.MultiTenancy.Dto;

namespace OrderFastFoot.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

