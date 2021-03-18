using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Application.Interfaces.Repositories
{
    public interface IEntityRepository<T> where T: BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAsync(Expression<Func<T,bool>> metot);
        Task<T> GetByIdAsync(int id);
    }
}
