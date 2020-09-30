
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using App.ExemploMvc.Tasks;
using App.ExemploMvc.Tasks.Dtos;
using App.ExemploMvc.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.ExemploMvc.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace App.ExemploMvc.Web.Controllers
{
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
