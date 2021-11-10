using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OrderFastFoot.Configuration.Dto;

namespace OrderFastFoot.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OrderFastFootAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
