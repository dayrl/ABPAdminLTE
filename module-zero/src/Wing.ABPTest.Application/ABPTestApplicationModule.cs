using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPTest.Authorization;

namespace Wing.ABPTest
{
    [DependsOn(
        typeof(ABPTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
