using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Wing.ABPTest.Authorization.Roles;
using Wing.ABPTest.Authorization.Users;
using Wing.ABPTest.MultiTenancy;

namespace Wing.ABPTest.EntityFrameworkCore
{
    public class ABPTestDbContext : AbpZeroDbContext<Tenant, Role, User, ABPTestDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public ABPTestDbContext(DbContextOptions<ABPTestDbContext> options)
            : base(options)
        {
        }
    }
}
