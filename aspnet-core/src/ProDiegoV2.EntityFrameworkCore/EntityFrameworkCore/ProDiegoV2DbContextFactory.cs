using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProDiegoV2.Configuration;
using ProDiegoV2.Web;

namespace ProDiegoV2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProDiegoV2DbContextFactory : IDesignTimeDbContextFactory<ProDiegoV2DbContext>
    {
        public ProDiegoV2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProDiegoV2DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProDiegoV2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProDiegoV2Consts.ConnectionStringName));

            return new ProDiegoV2DbContext(builder.Options);
        }
    }
}
