using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using OrderFastFood.Authorization.Roles;
using OrderFastFood.Authorization.Users;
using OrderFastFood.MultiTenancy;

namespace OrderFastFood.EntityFramework
{
    public class OrderFastFoodDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public OrderFastFoodDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in OrderFastFoodDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of OrderFastFoodDbContext since ABP automatically handles it.
         */
        public OrderFastFoodDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public OrderFastFoodDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public OrderFastFoodDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
