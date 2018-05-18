using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TQJProject.Configuration.Dto;

namespace TQJProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TQJProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
