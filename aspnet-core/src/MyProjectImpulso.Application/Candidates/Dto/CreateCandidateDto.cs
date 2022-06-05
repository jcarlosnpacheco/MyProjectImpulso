using Abp.AutoMapper;

namespace MyProjectImpulso.Candidates.Dto
{
    /// <summary>
    /// DTO for Create Candidate via Web API
    /// </summary>
    [AutoMapTo(typeof(Candidate))]
    public class CreateCandidateDto
    {
        /// <summary>
        /// Name of Candidate DTO
        /// </summary>
        public string Name { get; set; }
    }
}
