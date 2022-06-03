using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProjectImpulso.Candidates
{
    [Table("Candidates")]
    public class Candidate : FullAuditedEntity<int>
    {
        public string Name { get; set; }
    }
}
