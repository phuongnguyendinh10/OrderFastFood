using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OrderFastFoot.Authorization.Roles;
using OrderFastFoot.Authorization.Users;
using OrderFastFoot.MultiTenancy;

namespace OrderFastFoot.EntityFrameworkCore
{
    public class OrderFastFootDbContext : AbpZeroDbContext<Tenant, Role, User, OrderFastFootDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OrderFastFootDbContext(DbContextOptions<OrderFastFootDbContext> options)
            : base(options)
        {
        }
    }
}
