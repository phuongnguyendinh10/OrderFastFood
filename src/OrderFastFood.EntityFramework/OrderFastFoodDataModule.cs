using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using OrderFastFood.EntityFramework;

namespace OrderFastFood
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(OrderFastFoodCoreModule))]
    public class OrderFastFoodDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<OrderFastFoodDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
