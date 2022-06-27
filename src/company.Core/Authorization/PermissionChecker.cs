using Abp.Authorization;
using company.Authorization.Roles;
using company.Authorization.Users;

namespace company.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
