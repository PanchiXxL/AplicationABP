using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Example.Authorization;

namespace Example
{
    [DependsOn(
        typeof(ExampleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExampleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExampleAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExampleApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
