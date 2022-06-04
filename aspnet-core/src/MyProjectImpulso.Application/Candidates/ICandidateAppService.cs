using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProjectImpulso.Candidates.Dto;

namespace MyProjectImpulso.Candidates
{
    /// <summary>
    /// Interface for Candidade Application Service
    /// </summary>
    public interface ICandidateAppService : IAsyncCrudAppService<CandidateDto, int, PagedResultRequestDto, CreateCandidateDto, CandidateDto>
    {
    }
}
