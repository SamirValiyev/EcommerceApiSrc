using EcommerceApiSrc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T:class,IEntityBase,new()
    {
        Task AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task HardDeleteAsync(T entity);


    }
}
