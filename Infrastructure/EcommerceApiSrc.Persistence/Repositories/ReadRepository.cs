using EcommerceApiSrc.Application.Interfaces.Repositories;
using EcommerceApiSrc.Domain.Common;
using EcommerceApiSrc.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _appDbContext;
        public ReadRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }
        private DbSet<T> Table { get=>_appDbContext.Set<T>(); }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool tracking = false)
        {
           IQueryable<T> query= Table;
            if(!tracking) query=query.AsNoTracking();
            if (include is not null) query = include(query);
            if(predicate is not null) query=query.Where(predicate);
            if (orderBy is not null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();

        }
        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            Table.AsNoTracking();
            if(predicate is not null) Table.Where(predicate);
            return await Table.CountAsync();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate,bool tracking=false)
        {
            if(!tracking) Table.AsNoTracking();
            return Table.Where(predicate);
        }


        public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,Func<IQueryable<T>,IOrderedQueryable<T>>? orderBy=null, bool tracking = false, int currentPage = 1, int pageSize = 3)
        {
           IQueryable<T> query= Table;
            if (!tracking) Table.AsNoTracking();
            if(include is not null) query = include(query);
            if(predicate is not null ) Table.Where(predicate);
            if (orderBy is not null)
                return await orderBy(query).Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
            return await query.Skip((currentPage-1)*pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool tracking = false)
        {
            IQueryable<T> query = Table;
            if (!tracking) query = query.AsNoTracking();
            if (include is not null) query = include(query);
            return await query.FirstOrDefaultAsync(predicate);
        }
    }
}
