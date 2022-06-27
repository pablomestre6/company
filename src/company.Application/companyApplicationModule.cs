using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using company.Authorization;

namespace company
{
    [DependsOn(
        typeof(companyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class companyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<companyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(companyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
