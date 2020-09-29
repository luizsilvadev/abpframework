using System.Threading.Tasks;
using Abp.Application.Services;
using App.ExemploMvc.Sessions.Dto;

namespace App.ExemploMvc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
