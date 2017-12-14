using System.Threading.Tasks;
using Abp.Application.Services;
using Wing.ABPAdminLTE.Authorization.Accounts.Dto;

namespace Wing.ABPAdminLTE.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
