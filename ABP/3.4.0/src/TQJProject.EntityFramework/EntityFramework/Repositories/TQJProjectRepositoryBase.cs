using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TQJProject.EntityFramework.Repositories
{
    public abstract class TQJProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TQJProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TQJProjectRepositoryBase(IDbContextProvider<TQJProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TQJProjectRepositoryBase<TEntity> : TQJProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TQJProjectRepositoryBase(IDbContextProvider<TQJProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
