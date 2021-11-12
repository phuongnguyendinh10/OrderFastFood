using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OrderFastFood.Configuration.Dto;

namespace OrderFastFood.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OrderFastFoodAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
