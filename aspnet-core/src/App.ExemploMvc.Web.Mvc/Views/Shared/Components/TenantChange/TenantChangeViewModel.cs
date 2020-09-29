using Abp.AutoMapper;
using App.ExemploMvc.Sessions.Dto;

namespace App.ExemploMvc.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
