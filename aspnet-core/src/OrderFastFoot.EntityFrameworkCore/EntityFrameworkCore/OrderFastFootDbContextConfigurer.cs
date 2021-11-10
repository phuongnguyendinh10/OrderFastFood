using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OrderFastFoot.EntityFrameworkCore
{
    public static class OrderFastFootDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OrderFastFootDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OrderFastFootDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
