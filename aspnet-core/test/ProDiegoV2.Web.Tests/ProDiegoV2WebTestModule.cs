using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProDiegoV2.EntityFrameworkCore;
using ProDiegoV2.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ProDiegoV2.Web.Tests
{
    [DependsOn(
        typeof(ProDiegoV2WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ProDiegoV2WebTestModule : AbpModule
    {
        public ProDiegoV2WebTestModule(ProDiegoV2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProDiegoV2WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ProDiegoV2WebMvcModule).Assembly);
        }
    }
}