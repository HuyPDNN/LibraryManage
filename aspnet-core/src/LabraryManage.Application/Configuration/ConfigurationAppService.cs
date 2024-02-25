using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LabraryManage.Configuration.Dto;

namespace LabraryManage.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LabraryManageAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
