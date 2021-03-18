using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Application.Interfaces.UnitOfWork;
using Microsoft.EntityFrameworkCore.Storage;
using Persistence.Context;

namespace Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }


        public UnitOfWork(AppDbContext appDbContext, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _appDbContext = appDbContext;
            ProductRepository = productRepository;
            OrderRepository = orderRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _appDbContext.Database.BeginTransactionAsync();
        }

    }
}