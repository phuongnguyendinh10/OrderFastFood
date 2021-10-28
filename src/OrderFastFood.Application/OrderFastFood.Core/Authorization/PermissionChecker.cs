using Abp.Authorization;
using OrderFastFood.Authorization.Roles;
using OrderFastFood.Authorization.Users;

namespace OrderFastFood.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
