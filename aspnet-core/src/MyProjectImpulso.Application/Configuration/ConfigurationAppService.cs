using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyProjectImpulso.Configuration.Dto;

namespace MyProjectImpulso.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProjectImpulsoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
