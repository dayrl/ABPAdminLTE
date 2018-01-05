using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wing.ABPAdminLTE.EntityFrameworkCore.Seed;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    [DependsOn(
        typeof(ABPAdminLTECoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ABPAdminLTEEntityFrameworkCoreModule : AbpModule
    {
		/* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
		public bool SkipDbContextRegistration { get; set; }

		public bool SkipDbSeed { get; set; }

		public override void PreInitialize()
		{
			if (!SkipDbContextRegistration)
			{
				Configuration.Modules.AbpEfCore().AddDbContext<ABPAdminLTEDbContext>(options =>
				{
					if (options.ExistingConnection != null)
					{
						ABPAdminLTEDbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
					}
					else
					{
						ABPAdminLTEDbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
					}
				});
			}
		}
		public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPAdminLTEEntityFrameworkCoreModule).GetAssembly());
        }

		public override void PostInitialize()
		{
			if (!SkipDbSeed)
			{
				SeedHelper.SeedHostDb(IocManager);
			}
		}
	}
}