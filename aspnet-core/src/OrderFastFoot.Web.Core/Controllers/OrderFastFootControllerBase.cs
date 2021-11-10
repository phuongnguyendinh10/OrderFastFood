using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OrderFastFoot.Controllers
{
    public abstract class OrderFastFootControllerBase: AbpController
    {
        protected OrderFastFootControllerBase()
        {
            LocalizationSourceName = OrderFastFootConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
