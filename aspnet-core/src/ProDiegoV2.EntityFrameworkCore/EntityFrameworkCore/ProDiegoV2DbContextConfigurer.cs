using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProDiegoV2.EntityFrameworkCore
{
    public static class ProDiegoV2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProDiegoV2DbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProDiegoV2DbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
