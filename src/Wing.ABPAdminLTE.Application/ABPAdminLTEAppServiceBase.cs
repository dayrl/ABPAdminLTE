using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using Wing.ABPAdminLTE.Authorization.Users;
using Wing.ABPAdminLTE.MultiTenancy;

namespace Wing.ABPAdminLTE
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPAdminLTEAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }
        protected ABPAdminLTEAppServiceBase()
        {
            LocalizationSourceName = ABPAdminLTEConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}