using System.Collections.Generic;
using App.ExemploMvc.Roles.Dto;

namespace App.ExemploMvc.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
