using System.Collections.Generic;
using OrderFastFoot.Roles.Dto;

namespace OrderFastFoot.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
