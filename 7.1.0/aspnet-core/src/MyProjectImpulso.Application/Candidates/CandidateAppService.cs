using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyProjectImpulso.Candidates.Dto;

namespace MyProjectImpulso.Candidates
{
    [AbpAuthorize]
    public class CandidateAppService : AsyncCrudAppService<Candidate,CandidateDto,int, PagedResultRequestDto>, ICandidateAppService
    {
        public CandidateAppService(IRepository<Candidate, int> candidateTypeRepository)
            : base(candidateTypeRepository)
        {

        }
    }
}
