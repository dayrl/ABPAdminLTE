using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Wing.ABPAdminLTE
{
    [DependsOn(
        typeof(ABPAdminLTECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPAdminLTEApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTEApplicationModule).GetAssembly());
        }
    }
}