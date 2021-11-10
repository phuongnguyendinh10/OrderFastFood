using System.Threading.Tasks;
using OrderFastFoot.Configuration.Dto;

namespace OrderFastFoot.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
