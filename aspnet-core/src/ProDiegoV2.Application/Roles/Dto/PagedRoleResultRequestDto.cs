using Abp.Application.Services.Dto;

namespace ProDiegoV2.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

