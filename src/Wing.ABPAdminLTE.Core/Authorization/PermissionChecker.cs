using Abp.Authorization;
using Wing.ABPAdminLTE.Authorization.Roles;
using Wing.ABPAdminLTE.Authorization.Users;

namespace Wing.ABPAdminLTE.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
