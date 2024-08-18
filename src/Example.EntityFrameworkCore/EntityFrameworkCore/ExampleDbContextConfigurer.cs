using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Example.EntityFrameworkCore
{
    public static class ExampleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExampleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExampleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
