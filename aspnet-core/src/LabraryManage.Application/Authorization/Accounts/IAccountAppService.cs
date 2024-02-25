using System.Threading.Tasks;
using Abp.Application.Services;
using LabraryManage.Authorization.Accounts.Dto;

namespace LabraryManage.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
