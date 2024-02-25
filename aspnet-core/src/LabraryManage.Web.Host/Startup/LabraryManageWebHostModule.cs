using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LabraryManage.Configuration;

namespace LabraryManage.Web.Host.Startup
{
    [DependsOn(
       typeof(LabraryManageWebCoreModule))]
    public class LabraryManageWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LabraryManageWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LabraryManageWebHostModule).GetAssembly());
        }
    }
}
