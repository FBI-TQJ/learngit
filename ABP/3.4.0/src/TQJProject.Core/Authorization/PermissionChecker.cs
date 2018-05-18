using Abp.Authorization;
using TQJProject.Authorization.Roles;
using TQJProject.Authorization.Users;

namespace TQJProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
