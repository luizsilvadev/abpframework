using System.Threading.Tasks;
using App.ExemploMvc.Configuration.Dto;

namespace App.ExemploMvc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
