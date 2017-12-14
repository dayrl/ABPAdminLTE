using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Wing.ABPAdminLTE.Controllers
{
    public abstract class ABPAdminLTEControllerBase: AbpController
    {
        protected ABPAdminLTEControllerBase()
        {
            LocalizationSourceName = ABPAdminLTEConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
