using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using App.ExemploMvc.Tasks;
using App.ExemploMvc.Tasks.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.ExemploMvc.Web.Models.Tasks
{
    public class IndexViewModel
    {
        public IReadOnlyList<TaskListDto> Tasks { get; }

        public IndexViewModel(IReadOnlyList<TaskListDto> tasks)
        {
            Tasks = tasks;
        }

        public string GetTaskLabel(TaskListDto task)
        {
            switch (task.State)
            {
                case TaskState.Open:
                    return "badge-success";
                default:
                    return "badge-info";
            }
        }
    }
}
