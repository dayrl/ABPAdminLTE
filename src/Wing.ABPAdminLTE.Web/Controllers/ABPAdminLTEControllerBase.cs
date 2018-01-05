using Abp.AspNetCore.Mvc.Controllers;

namespace Wing.ABPAdminLTE.Web.Controllers
{
    public abstract class ABPAdminLTEControllerBase: AbpController
    {
        protected ABPAdminLTEControllerBase()
        {
            LocalizationSourceName = ABPAdminLTEConsts.LocalizationSourceName;
        }
    }
}