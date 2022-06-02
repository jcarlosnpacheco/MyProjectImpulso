using Abp.Application.Services.Dto;

namespace MyProjectImpulso.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

