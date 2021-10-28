using Abp.Web.Mvc.Views;

namespace OrderFastFood.Web.Views
{
    public abstract class OrderFastFoodWebViewPageBase : OrderFastFoodWebViewPageBase<dynamic>
    {

    }

    public abstract class OrderFastFoodWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected OrderFastFoodWebViewPageBase()
        {
            LocalizationSourceName = OrderFastFoodConsts.LocalizationSourceName;
        }
    }
}