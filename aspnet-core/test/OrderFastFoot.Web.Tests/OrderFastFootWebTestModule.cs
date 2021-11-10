using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrderFastFoot.EntityFrameworkCore;
using OrderFastFoot.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OrderFastFoot.Web.Tests
{
    [DependsOn(
        typeof(OrderFastFootWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OrderFastFootWebTestModule : AbpModule
    {
        public OrderFastFootWebTestModule(OrderFastFootEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OrderFastFootWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OrderFastFootWebMvcModule).Assembly);
        }
    }
}