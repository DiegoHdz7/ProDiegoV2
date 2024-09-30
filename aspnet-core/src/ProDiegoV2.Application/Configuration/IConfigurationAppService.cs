using System.Threading.Tasks;
using ProDiegoV2.Configuration.Dto;

namespace ProDiegoV2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
