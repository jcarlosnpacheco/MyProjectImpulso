using System.Threading.Tasks;
using Abp.Application.Services;
using MyProjectImpulso.Sessions.Dto;

namespace MyProjectImpulso.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
