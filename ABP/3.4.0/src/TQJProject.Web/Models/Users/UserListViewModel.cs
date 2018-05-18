using System.Collections.Generic;
using TQJProject.Roles.Dto;
using TQJProject.Users.Dto;

namespace TQJProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}