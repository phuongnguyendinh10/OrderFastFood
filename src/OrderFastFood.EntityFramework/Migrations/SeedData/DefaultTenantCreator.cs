using System.Linq;
using OrderFastFood.EntityFramework;
using OrderFastFood.MultiTenancy;

namespace OrderFastFood.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly OrderFastFoodDbContext _context;

        public DefaultTenantCreator(OrderFastFoodDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
