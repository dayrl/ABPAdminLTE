using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Wing.ABPTest.MultiTenancy.Dto;

namespace Wing.ABPTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
