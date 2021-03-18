using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync();

        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
    }
}