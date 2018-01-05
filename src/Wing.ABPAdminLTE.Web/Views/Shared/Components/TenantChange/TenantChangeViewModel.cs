using Abp.AutoMapper;
using Wing.ABPAdminLTE.Sessions.Dto;

namespace Wing.ABPAdminLTE.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}