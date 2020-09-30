using System;
using System.Collections.Generic;
using System.Text;

namespace App.ExemploMvc.Tasks.Dtos
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}
