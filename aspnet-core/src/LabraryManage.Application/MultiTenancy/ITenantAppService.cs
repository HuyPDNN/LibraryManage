using Abp.Application.Services;
using LabraryManage.MultiTenancy.Dto;

namespace LabraryManage.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

