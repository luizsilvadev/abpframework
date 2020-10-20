
using System.Threading.Tasks;
using App.ExemploMvc.Tasks;
using App.ExemploMvc.Tasks.Dtos;
using App.ExemploMvc.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.ExemploMvc.Controllers;
using Abp.AspNetCore.Mvc.Authorization;

namespace App.ExemploMvc.Web.Controllers
{
    [AbpMvcAuthorize]
    public class TasksController : ExemploMvcControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }
}
