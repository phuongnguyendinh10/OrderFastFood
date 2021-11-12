using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using OrderFastFood.EntityFramework;

namespace OrderFastFood.Migrator
{
    [DependsOn(typeof(OrderFastFoodDataModule))]
    public class OrderFastFoodMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<OrderFastFoodDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}