using Wing.ABPAdminLTE.Configuration;
using Wing.ABPAdminLTE.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class ABPAdminLTEDbContextFactory : IDesignTimeDbContextFactory<ABPAdminLTEDbContext>
    {
        public ABPAdminLTEDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPAdminLTEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(ABPAdminLTEConsts.ConnectionStringName)
            );

            return new ABPAdminLTEDbContext(builder.Options);
        }
    }
}