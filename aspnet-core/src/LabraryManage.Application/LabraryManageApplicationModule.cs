using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LabraryManage.Authorization;

namespace LabraryManage
{
    [DependsOn(
        typeof(LabraryManageCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LabraryManageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LabraryManageAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LabraryManageApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
