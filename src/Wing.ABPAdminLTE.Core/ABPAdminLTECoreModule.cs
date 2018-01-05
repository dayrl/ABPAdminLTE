using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Wing.ABPAdminLTE.Authorization.Roles;
using Wing.ABPAdminLTE.Authorization.Users;
using Wing.ABPAdminLTE.Configuration;
using Wing.ABPAdminLTE.Localization;
using Wing.ABPAdminLTE.MultiTenancy;
using Wing.ABPAdminLTE.Timing;

namespace Wing.ABPAdminLTE
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ABPAdminLTECoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ABPAdminLTELocalizationConfigurer.Configure(Configuration.Localization);


            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ABPAdminLTEConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTECoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}