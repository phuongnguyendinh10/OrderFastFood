using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrderFastFoot.Configuration;

namespace OrderFastFoot.Web.Host.Startup
{
    [DependsOn(
       typeof(OrderFastFootWebCoreModule))]
    public class OrderFastFootWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OrderFastFootWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OrderFastFootWebHostModule).GetAssembly());
        }
    }
}
