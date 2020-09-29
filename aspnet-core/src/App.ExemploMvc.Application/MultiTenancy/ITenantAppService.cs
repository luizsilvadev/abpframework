using Abp.Application.Services;
using App.ExemploMvc.MultiTenancy.Dto;

namespace App.ExemploMvc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

