using Abp.Application.Services;
using System.Threading.Tasks;
using Wing.ABPAdminLTE.Sessions.Dto;

namespace Wing.ABPAdminLTE.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
