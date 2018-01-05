using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPAdminLTE.Authorization;

namespace Wing.ABPAdminLTE
{
    [DependsOn(
        typeof(ABPAdminLTECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPAdminLTEApplicationModule : AbpModule
    {
		public override void PreInitialize()
		{
			Configuration.Authorization.Providers.Add<ABPAdminLTEAuthorizationProvider>();
		}
		public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTEApplicationModule).GetAssembly());
        }
    }
}