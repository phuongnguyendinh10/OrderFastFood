using Abp.AutoMapper;
using OrderFastFood.Sessions.Dto;

namespace OrderFastFood.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}