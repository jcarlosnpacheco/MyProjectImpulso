using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyProjectImpulso.Candidates.Dto;

namespace MyProjectImpulso.Candidates
{
    /// <summary>
    /// Candidate Application Service
    /// </summary>
    [AbpAuthorize]
    public class CandidateAppService : AsyncCrudAppService<Candidate, CandidateDto, int, PagedResultRequestDto, CreateCandidateDto, CandidateDto>, ICandidateAppService
    {
        /// <summary>
        /// Constructor for dependency injection of Candidate Application Service
        /// </summary>
        /// <param name="candidateTypeRepository"></param>
        public CandidateAppService(IRepository<Candidate, int> candidateTypeRepository)
            : base(candidateTypeRepository)
        {

        }
    }
}
