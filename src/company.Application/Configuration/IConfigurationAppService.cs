using System.Threading.Tasks;
using company.Configuration.Dto;

namespace company.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
