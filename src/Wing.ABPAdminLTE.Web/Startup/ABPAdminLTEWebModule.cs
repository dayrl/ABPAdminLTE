using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPAdminLTE.Configuration;
using Wing.ABPAdminLTE.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Wing.ABPAdminLTE.Web.Startup
{
    [DependsOn(
        typeof(ABPAdminLTEApplicationModule), 
        typeof(ABPAdminLTEEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class ABPAdminLTEWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ABPAdminLTEWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ABPAdminLTEConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<ABPAdminLTENavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ABPAdminLTEApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTEWebModule).GetAssembly());
        }
    }
}