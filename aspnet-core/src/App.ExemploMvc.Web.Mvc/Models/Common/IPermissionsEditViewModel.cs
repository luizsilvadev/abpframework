using System.Collections.Generic;
using App.ExemploMvc.Roles.Dto;

namespace App.ExemploMvc.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}