using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using App.ExemploMvc.Configuration.Dto;

namespace App.ExemploMvc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExemploMvcAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
