using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using App.ExemploMvc.Tasks.Dtos;

namespace App.ExemploMvc.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);

        //System.Threading.Tasks.Task Create(CreateTaskInput input);
    }
}
