using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrderFastFoot.Configuration;

namespace OrderFastFoot.Web.Startup
{
    [DependsOn(typeof(OrderFastFootWebCoreModule))]
    public class OrderFastFootWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OrderFastFootWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<OrderFastFootNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OrderFastFootWebMvcModule).GetAssembly());
        }
    }
}
