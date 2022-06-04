using System.Threading.Tasks;
using MyProjectImpulso.Configuration.Dto;

namespace MyProjectImpulso.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
