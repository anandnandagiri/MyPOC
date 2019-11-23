using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyProduct.Business.Contracts.Repositories;


namespace MyProduct.Repositories
{
    public class BaseRepository<TEntity>  where TEntity : class
    {
        protected readonly DbContext Context;

        public BaseRepository()
        {
        }

        public BaseRepository(DbContext context)
        {
            Context = context;
        }

        protected TEntity GetByID(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        protected IEnumerable<TEntity> GetAll()
        {            
            return Context.Set<TEntity>().ToList();
        }

        protected IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        protected TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        protected void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        protected void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        protected void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        protected void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        protected void Edit(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }


        protected Task<TEntity> GetByIDAsyn(int id)
        {
            throw new NotImplementedException();
        }

        protected Task<IEnumerable<TEntity>> GetAllAsyn()
        {
            throw new NotImplementedException();
        }

        protected Task AddAsyn(TEntity entity)
        {
            throw new NotImplementedException();
        }

        protected Task AddRangeAsyn(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        protected Task RemoveAsyn(TEntity entity)
        {
            throw new NotImplementedException();
        }

        protected Task RemoveRangeAsyn(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
        
        protected Task EditAsyn(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
