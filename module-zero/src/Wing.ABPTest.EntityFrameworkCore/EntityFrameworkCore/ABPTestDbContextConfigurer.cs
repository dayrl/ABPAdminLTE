using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Wing.ABPTest.EntityFrameworkCore
{
    public static class ABPTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
