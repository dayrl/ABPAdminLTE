using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPAdminLTE.Localization;

namespace Wing.ABPAdminLTE
{
    public class ABPAdminLTECoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            ABPAdminLTELocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTECoreModule).GetAssembly());
        }
    }
}