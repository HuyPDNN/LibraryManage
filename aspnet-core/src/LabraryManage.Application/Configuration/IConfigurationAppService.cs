using System.Threading.Tasks;
using LabraryManage.Configuration.Dto;

namespace LabraryManage.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
