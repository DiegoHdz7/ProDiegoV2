using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProDiegoV2.Configuration.Dto;

namespace ProDiegoV2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProDiegoV2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
