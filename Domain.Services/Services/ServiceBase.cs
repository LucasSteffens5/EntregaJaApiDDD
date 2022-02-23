using Domain.Core.Interfaces.Repository;
using Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }


        public async Task<int> AddAsync(TEntity entity)       
            =>  await _repository.AddAsync(entity);

        

        public async Task<IEnumerable<TEntity>> ListAsync()
            => await _repository.ListAsync();

        public async Task<TEntity> GetByIdAsync(int id)
            => await _repository.GetByIdAsync(id);

        public async Task RemoveAsync(TEntity entity)
        {
            await _repository.RemoveAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression)
            => await _repository.ListAsync(expression);

        public async Task UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
        }

    }
}
