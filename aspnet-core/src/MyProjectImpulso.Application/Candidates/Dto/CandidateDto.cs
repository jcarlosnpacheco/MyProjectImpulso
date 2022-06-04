using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MyProjectImpulso.Candidates.Dto
{
    /// <summary>
    /// Candidate DTO with Auto Mapper and extends
    /// </summary>
    [AutoMapFrom(typeof(Candidate))]
    public class CandidateDto : FullAuditedEntityDto<int>
    {
        /// <summary>
        /// Name of Candidate DTO
        /// </summary>
        public string Name { get; set; }
    }
}
