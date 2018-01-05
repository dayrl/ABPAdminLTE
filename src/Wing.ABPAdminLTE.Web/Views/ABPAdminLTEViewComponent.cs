using Abp.AspNetCore.Mvc.ViewComponents;
using Wing.ABPAdminLTE;

namespace Wing.ABPAdminLTE.Web.Views
{
    public abstract class ABPAdminLTEViewComponent : AbpViewComponent
    {
        protected ABPAdminLTEViewComponent()
        {
            LocalizationSourceName = ABPAdminLTEConsts.LocalizationSourceName;
        }
    }
}