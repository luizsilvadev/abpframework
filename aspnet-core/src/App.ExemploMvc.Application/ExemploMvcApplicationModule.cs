using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App.ExemploMvc.Authorization;

namespace App.ExemploMvc
{
    [DependsOn(
        typeof(ExemploMvcCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExemploMvcApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExemploMvcAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExemploMvcApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
