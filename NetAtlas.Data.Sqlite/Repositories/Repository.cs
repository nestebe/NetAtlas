using NetAtlas.Core.Interfaces.Repositories;
using NetAtlas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Data.Sqlite.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly AtlasDatabase Context;

        public Repository(AtlasDatabase context)
        {
            this.Context = context;
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return (IEnumerable<TEntity>)await Context.Database.GetAsync<TEntity>(predicate);
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetAsync(string id)
        {
            var entity = await Context.Database.GetAsync<TEntity>(id);
            return entity;
        }

        public Task Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAsync(TEntity entity)
        {


                return await Context.Database.InsertAsync(entity);

               // return await Context.Database.UpdateAsync(entity);
        }
    }
}
