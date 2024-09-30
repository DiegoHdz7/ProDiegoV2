using Abp.Application.Services;
using ProDiegoV2.MultiTenancy.Dto;

namespace ProDiegoV2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

