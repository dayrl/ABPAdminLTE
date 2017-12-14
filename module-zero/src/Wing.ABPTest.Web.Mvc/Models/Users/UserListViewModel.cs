using System.Collections.Generic;
using Wing.ABPTest.Roles.Dto;
using Wing.ABPTest.Users.Dto;

namespace Wing.ABPTest.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}