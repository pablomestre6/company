using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using company.Configuration.Dto;

namespace company.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : companyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
