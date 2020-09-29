using System.Threading.Tasks;
using Abp.Application.Services;
using App.ExemploMvc.Authorization.Accounts.Dto;

namespace App.ExemploMvc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
