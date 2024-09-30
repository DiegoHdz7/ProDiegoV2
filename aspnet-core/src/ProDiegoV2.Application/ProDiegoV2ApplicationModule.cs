using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProDiegoV2.Authorization;

namespace ProDiegoV2
{
    [DependsOn(
        typeof(ProDiegoV2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProDiegoV2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProDiegoV2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProDiegoV2ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
