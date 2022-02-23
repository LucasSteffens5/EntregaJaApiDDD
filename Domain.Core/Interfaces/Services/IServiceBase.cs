using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<int> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> ListAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task RemoveAsync(TEntity entity);

        Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression);

        Task UpdateAsync(TEntity entity);
    }
}
