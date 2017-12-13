using Abp.Application.Services;

namespace Wing.ABPAdminLTE
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPAdminLTEAppServiceBase : ApplicationService
    {
        protected ABPAdminLTEAppServiceBase()
        {
            LocalizationSourceName = ABPAdminLTEConsts.LocalizationSourceName;
        }
    }
}