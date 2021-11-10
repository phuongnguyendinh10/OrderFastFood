using System.Collections.Generic;
using OrderFastFoot.Roles.Dto;

namespace OrderFastFoot.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
