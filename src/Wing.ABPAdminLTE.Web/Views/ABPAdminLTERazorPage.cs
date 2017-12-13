using Abp.AspNetCore.Mvc.Views;

namespace Wing.ABPAdminLTE.Web.Views
{
    public abstract class ABPAdminLTERazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ABPAdminLTERazorPage()
        {
            LocalizationSourceName = ABPAdminLTEConsts.LocalizationSourceName;
        }
    }
}
