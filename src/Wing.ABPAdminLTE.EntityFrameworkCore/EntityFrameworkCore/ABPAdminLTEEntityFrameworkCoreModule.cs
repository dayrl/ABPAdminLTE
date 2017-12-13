using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    [DependsOn(
        typeof(ABPAdminLTECoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ABPAdminLTEEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTEEntityFrameworkCoreModule).GetAssembly());
        }
    }
}