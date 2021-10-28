using System.Threading.Tasks;
using Abp.Application.Services;
using OrderFastFood.Configuration.Dto;

namespace OrderFastFood.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}