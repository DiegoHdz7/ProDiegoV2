using Abp.Authorization;
using ProDiegoV2.Authorization.Roles;
using ProDiegoV2.Authorization.Users;

namespace ProDiegoV2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
