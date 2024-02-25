using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LabraryManage.Configuration;
using LabraryManage.Web;

namespace LabraryManage.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LabraryManageDbContextFactory : IDesignTimeDbContextFactory<LabraryManageDbContext>
    {
        public LabraryManageDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LabraryManageDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LabraryManageDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LabraryManageConsts.ConnectionStringName));

            return new LabraryManageDbContext(builder.Options);
        }
    }
}
