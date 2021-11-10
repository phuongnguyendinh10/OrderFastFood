using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrderFastFoot.Authorization;

namespace OrderFastFoot
{
    [DependsOn(
        typeof(OrderFastFootCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OrderFastFootApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OrderFastFootAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OrderFastFootApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
