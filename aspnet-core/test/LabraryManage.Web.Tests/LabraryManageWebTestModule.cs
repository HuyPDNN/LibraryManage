using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LabraryManage.EntityFrameworkCore;
using LabraryManage.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LabraryManage.Web.Tests
{
    [DependsOn(
        typeof(LabraryManageWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LabraryManageWebTestModule : AbpModule
    {
        public LabraryManageWebTestModule(LabraryManageEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LabraryManageWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LabraryManageWebMvcModule).Assembly);
        }
    }
}