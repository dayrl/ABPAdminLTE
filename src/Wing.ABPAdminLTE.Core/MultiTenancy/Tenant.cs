using Abp.MultiTenancy;
using Wing.ABPAdminLTE.Authorization.Users;

namespace Wing.ABPAdminLTE.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
