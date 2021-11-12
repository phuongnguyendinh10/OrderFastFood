using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OrderFastFood.MultiTenancy.Dto;

namespace OrderFastFood.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
