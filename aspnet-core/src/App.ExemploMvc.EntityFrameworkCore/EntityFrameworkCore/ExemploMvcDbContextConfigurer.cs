using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using FirebirdSql.EntityFrameworkCore.Firebird;
using System.Text;

namespace App.ExemploMvc.EntityFrameworkCore
{
    public static class ExemploMvcDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExemploMvcDbContext> builder, string connectionString)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //builder.UseSqlServer(connectionString);
            builder.UseFirebird(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExemploMvcDbContext> builder, DbConnection connection)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //builder.UseSqlServer(connection);
            builder.UseFirebird(connection);
        }
    }
}
