using Microsoft.EntityFrameworkCore;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<ABPAdminLTEDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for ABPAdminLTEDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
