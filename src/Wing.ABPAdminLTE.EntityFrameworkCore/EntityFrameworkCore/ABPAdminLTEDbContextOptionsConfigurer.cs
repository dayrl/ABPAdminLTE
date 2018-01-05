using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    public static class ABPAdminLTEDbContextOptionsConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPAdminLTEDbContext> builder, string connectionString)
        {
			/* This is the single point to configure DbContextOptions for ABPAdminLTEDbContext */
			builder.UseSqlServer(connectionString);
        }

		public static void Configure(DbContextOptionsBuilder<ABPAdminLTEDbContext> builder, DbConnection connection)
		{
			builder.UseSqlServer(connection);
		}
	}
}
