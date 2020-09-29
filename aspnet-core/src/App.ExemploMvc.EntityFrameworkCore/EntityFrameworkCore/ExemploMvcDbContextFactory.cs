using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using App.ExemploMvc.Configuration;
using App.ExemploMvc.Web;

namespace App.ExemploMvc.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ExemploMvcDbContextFactory : IDesignTimeDbContextFactory<ExemploMvcDbContext>
    {
        public ExemploMvcDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ExemploMvcDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ExemploMvcDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ExemploMvcConsts.ConnectionStringName));

            return new ExemploMvcDbContext(builder.Options);
        }
    }
}
