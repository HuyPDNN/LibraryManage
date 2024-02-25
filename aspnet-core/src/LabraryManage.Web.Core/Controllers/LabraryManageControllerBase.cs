using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LabraryManage.Controllers
{
    public abstract class LabraryManageControllerBase: AbpController
    {
        protected LabraryManageControllerBase()
        {
            LocalizationSourceName = LabraryManageConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
