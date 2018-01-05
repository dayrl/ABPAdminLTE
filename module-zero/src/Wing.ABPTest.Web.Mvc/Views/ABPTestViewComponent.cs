using Abp.AspNetCore.Mvc.ViewComponents;

namespace Wing.ABPTest.Web.Views
{
    public abstract class ABPTestViewComponent : AbpViewComponent
    {
        protected ABPTestViewComponent()
        {
            LocalizationSourceName = ABPTestConsts.LocalizationSourceName;
        }
    }
}