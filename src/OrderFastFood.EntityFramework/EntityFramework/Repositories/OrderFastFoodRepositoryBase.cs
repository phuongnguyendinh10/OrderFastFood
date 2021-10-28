using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace OrderFastFood.EntityFramework.Repositories
{
    public abstract class OrderFastFoodRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<OrderFastFoodDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected OrderFastFoodRepositoryBase(IDbContextProvider<OrderFastFoodDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class OrderFastFoodRepositoryBase<TEntity> : OrderFastFoodRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected OrderFastFoodRepositoryBase(IDbContextProvider<OrderFastFoodDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
