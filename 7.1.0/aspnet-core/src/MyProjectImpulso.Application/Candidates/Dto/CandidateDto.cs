using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MyProjectImpulso.Candidates.Dto
{
    [AutoMapTo(typeof(Candidate))]
    public class CandidateDto : FullAuditedEntityDto<int>
    {
        public string Name { get; set; }
    }
}
