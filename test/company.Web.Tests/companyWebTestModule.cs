using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using company.EntityFrameworkCore;
using company.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace company.Web.Tests
{
    [DependsOn(
        typeof(companyWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class companyWebTestModule : AbpModule
    {
        public companyWebTestModule(companyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(companyWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(companyWebMvcModule).Assembly);
        }
    }
}