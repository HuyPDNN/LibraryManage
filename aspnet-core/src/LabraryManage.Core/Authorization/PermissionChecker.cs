using Abp.Authorization;
using LabraryManage.Authorization.Roles;
using LabraryManage.Authorization.Users;

namespace LabraryManage.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
