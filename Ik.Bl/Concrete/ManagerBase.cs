using Ik.Bl.Abstract;
using Ik.Dal.Concrete;
using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Bl.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity
    {
        private readonly RepositoryBase<T> repository;

        public ManagerBase()
        {
            this.repository = new RepositoryBase<T>();
        }

        public async Task<int> DeleteAsync(T entity)
        {
           return  await repository.DeleteAsync(entity);
          
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return await repository.GetAllAsync(filter);
        }

        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            return await repository.GetAllInclude(filter, include);
        }

        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await repository.GetBy(filter);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            return await repository.InsertAsync(entity);
        }

        public async Task<int> UpdateAsync(T entity)
        {
            return await repository.UpdateAsync(entity);
        }
    }
    
}
