using System.Collections.Generic;
using OrderFastFood.Roles.Dto;
using OrderFastFood.Users.Dto;

namespace OrderFastFood.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}