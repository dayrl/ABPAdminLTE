using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Wing.ABPTest.Web.Views
{
    public abstract class ABPTestRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPTestRazorPage()
        {
            LocalizationSourceName = ABPTestConsts.LocalizationSourceName;
        }
    }
}
