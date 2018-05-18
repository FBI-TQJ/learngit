using System.Threading.Tasks;
using Abp.Application.Services;
using TQJProject.Configuration.Dto;

namespace TQJProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}