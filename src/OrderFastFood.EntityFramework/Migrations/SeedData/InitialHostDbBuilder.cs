using OrderFastFood.EntityFramework;
using EntityFramework.DynamicFilters;

namespace OrderFastFood.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly OrderFastFoodDbContext _context;

        public InitialHostDbBuilder(OrderFastFoodDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
