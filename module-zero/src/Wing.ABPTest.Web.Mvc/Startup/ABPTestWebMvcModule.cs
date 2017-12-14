using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPTest.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Wing.ABPTest.Web.Startup
{
    [DependsOn(typeof(ABPTestWebCoreModule))]
    public class ABPTestWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPTestWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ABPTestNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPTestWebMvcModule).GetAssembly());
        }
    }
}