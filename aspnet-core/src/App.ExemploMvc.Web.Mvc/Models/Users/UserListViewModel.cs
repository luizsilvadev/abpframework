using System.Collections.Generic;
using App.ExemploMvc.Roles.Dto;

namespace App.ExemploMvc.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
