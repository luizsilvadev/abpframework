using Abp.AutoMapper;
using App.ExemploMvc.Roles.Dto;
using App.ExemploMvc.Web.Models.Common;

namespace App.ExemploMvc.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
