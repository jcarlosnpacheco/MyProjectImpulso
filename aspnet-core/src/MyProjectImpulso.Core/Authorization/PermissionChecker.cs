using Abp.Authorization;
using MyProjectImpulso.Authorization.Roles;
using MyProjectImpulso.Authorization.Users;

namespace MyProjectImpulso.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
