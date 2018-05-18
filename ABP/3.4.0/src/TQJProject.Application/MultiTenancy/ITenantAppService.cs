using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TQJProject.MultiTenancy.Dto;

namespace TQJProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
