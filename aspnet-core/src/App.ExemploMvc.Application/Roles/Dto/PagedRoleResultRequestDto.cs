using Abp.Application.Services.Dto;

namespace App.ExemploMvc.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

