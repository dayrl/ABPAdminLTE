using System.Threading.Tasks;
using Abp.Application.Services;
using Wing.ABPTest.Sessions.Dto;

namespace Wing.ABPTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
