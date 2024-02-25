using System.Threading.Tasks;
using Abp.Application.Services;
using LabraryManage.Sessions.Dto;

namespace LabraryManage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
