using Abp.Authorization;
using Wing.ABPTest.Authorization.Roles;
using Wing.ABPTest.Authorization.Users;

namespace Wing.ABPTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
