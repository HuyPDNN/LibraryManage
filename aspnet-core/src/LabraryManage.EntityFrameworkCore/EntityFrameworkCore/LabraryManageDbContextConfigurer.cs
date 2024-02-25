using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LabraryManage.EntityFrameworkCore
{
    public static class LabraryManageDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LabraryManageDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LabraryManageDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
