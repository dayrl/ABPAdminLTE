using Abp.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wing.ABPAdminLTE.Authorization.Roles;
using Wing.ABPAdminLTE.Authorization.Users;
using Wing.ABPAdminLTE.MultiTenancy;

namespace Wing.ABPAdminLTE.EntityFrameworkCore
{
    public class ABPAdminLTEDbContext : AbpZeroDbContext<Tenant,Role,User, ABPAdminLTEDbContext>
    {
        //Add DbSet properties for your entities...

        public ABPAdminLTEDbContext(DbContextOptions<ABPAdminLTEDbContext> options) 
            : base(options)
        {

        }
    }
}
