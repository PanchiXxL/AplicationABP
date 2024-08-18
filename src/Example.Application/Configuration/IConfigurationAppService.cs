using System.Threading.Tasks;
using Example.Configuration.Dto;

namespace Example.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
