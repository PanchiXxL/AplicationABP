using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Example.EntityFrameworkCore;
using Example.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Example.Web.Tests
{
    [DependsOn(
        typeof(ExampleWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ExampleWebTestModule : AbpModule
    {
        public ExampleWebTestModule(ExampleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExampleWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ExampleWebMvcModule).Assembly);
        }
    }
}