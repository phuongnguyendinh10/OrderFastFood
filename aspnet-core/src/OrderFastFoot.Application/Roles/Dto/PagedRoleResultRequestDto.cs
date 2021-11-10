using Abp.Application.Services.Dto;

namespace OrderFastFoot.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

