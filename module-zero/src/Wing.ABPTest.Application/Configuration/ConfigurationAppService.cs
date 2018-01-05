using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Wing.ABPTest.Configuration.Dto;

namespace Wing.ABPTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
