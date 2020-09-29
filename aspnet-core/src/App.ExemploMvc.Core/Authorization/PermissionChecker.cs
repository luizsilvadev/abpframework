using Abp.Authorization;
using App.ExemploMvc.Authorization.Roles;
using App.ExemploMvc.Authorization.Users;

namespace App.ExemploMvc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
