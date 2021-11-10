using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace OrderFastFoot.Web.Views
{
    public abstract class OrderFastFootRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected OrderFastFootRazorPage()
        {
            LocalizationSourceName = OrderFastFootConsts.LocalizationSourceName;
        }
    }
}
