using Abp.Authorization;
using OrderFastFoot.Authorization.Roles;
using OrderFastFoot.Authorization.Users;

namespace OrderFastFoot.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
