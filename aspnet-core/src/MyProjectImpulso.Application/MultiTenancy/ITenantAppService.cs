using Abp.Application.Services;
using MyProjectImpulso.MultiTenancy.Dto;

namespace MyProjectImpulso.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

