using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repository
{
    public class EfEntityRepository<T> : IEntityRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;
        private DbSet<T> Table => _appDbContext.Set<T>();

        public EfEntityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>> metot)
        {
            return await Table.Where(metot).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }
    }
}
