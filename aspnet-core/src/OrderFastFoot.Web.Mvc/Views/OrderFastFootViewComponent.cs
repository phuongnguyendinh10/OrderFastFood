using Abp.AspNetCore.Mvc.ViewComponents;

namespace OrderFastFoot.Web.Views
{
    public abstract class OrderFastFootViewComponent : AbpViewComponent
    {
        protected OrderFastFootViewComponent()
        {
            LocalizationSourceName = OrderFastFootConsts.LocalizationSourceName;
        }
    }
}
