using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App.ExemploMvc.EntityFrameworkCore;
using App.ExemploMvc.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace App.ExemploMvc.Web.Tests
{
    [DependsOn(
        typeof(ExemploMvcWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ExemploMvcWebTestModule : AbpModule
    {
        public ExemploMvcWebTestModule(ExemploMvcEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExemploMvcWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ExemploMvcWebMvcModule).Assembly);
        }
    }
}