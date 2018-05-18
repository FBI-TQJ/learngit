using System.Threading.Tasks;
using Abp.Application.Services;
using TQJProject.Sessions.Dto;

namespace TQJProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
