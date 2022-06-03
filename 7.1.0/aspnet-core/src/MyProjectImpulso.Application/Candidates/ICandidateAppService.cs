using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProjectImpulso.Candidates.Dto;

namespace MyProjectImpulso.Candidates
{
    public interface ICandidateAppService : IAsyncCrudAppService<CandidateDto, int, PagedResultRequestDto>
    {
    }
}
