using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Example.Configuration.Dto;

namespace Example.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExampleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
