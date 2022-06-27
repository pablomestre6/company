using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace company.EntityFrameworkCore
{
    public static class companyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<companyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<companyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
