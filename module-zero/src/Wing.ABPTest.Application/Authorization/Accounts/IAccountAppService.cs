using System.Threading.Tasks;
using Abp.Application.Services;
using Wing.ABPTest.Authorization.Accounts.Dto;

namespace Wing.ABPTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
