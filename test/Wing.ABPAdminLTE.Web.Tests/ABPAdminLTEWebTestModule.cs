using System.Reflection;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPAdminLTE.Web.Startup;

namespace Wing.ABPAdminLTE.Web.Tests
{
    [DependsOn(
        typeof(ABPAdminLTEWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class ABPAdminLTEWebTestModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTEWebTestModule).GetAssembly());
        }
    }
}