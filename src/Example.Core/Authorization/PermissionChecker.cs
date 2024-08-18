using Abp.Authorization;
using Example.Authorization.Roles;
using Example.Authorization.Users;

namespace Example.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
