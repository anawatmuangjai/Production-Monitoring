using PDR.Web.Context;
using PDR.Web.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PDR.Web.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext context;

        protected Repository()
            : this(new DatabaseContext())
        {
        }

        protected Repository(DatabaseContext context)
        {
            this.context = context;
        }

        protected virtual IQueryable<T> GetQueryable(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = context.Set<T>();

            if (filter != null)
                query = query.Where(filter);

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            if (orderby != null)
                query = orderby(query);

            return query;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            params Expression<Func<T, object>>[] includes)
        {
            return await GetQueryable(null, orderby, includes).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            params Expression<Func<T, object>>[] includes)
        {
            return await GetQueryable(filter, orderby, includes).ToListAsync();
        }
    }
}