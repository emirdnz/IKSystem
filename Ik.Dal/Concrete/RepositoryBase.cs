using Ik.Dal.Abstract;
using Ik.Dal.Context;
using Ik.entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Dal.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        public IKDB dbContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<int> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }

}