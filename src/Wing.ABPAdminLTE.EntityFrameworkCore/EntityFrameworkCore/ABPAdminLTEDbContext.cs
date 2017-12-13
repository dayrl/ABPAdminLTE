using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    public class ABPAdminLTEDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public ABPAdminLTEDbContext(DbContextOptions<ABPAdminLTEDbContext> options) 
            : base(options)
        {

        }
    }
}
