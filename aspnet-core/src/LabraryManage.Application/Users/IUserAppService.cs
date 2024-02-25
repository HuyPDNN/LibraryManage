using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LabraryManage.Roles.Dto;
using LabraryManage.Users.Dto;

namespace LabraryManage.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
