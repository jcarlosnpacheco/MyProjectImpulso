using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyProjectImpulso.EntityFrameworkCore
{
    public static class MyProjectImpulsoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectImpulsoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectImpulsoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
