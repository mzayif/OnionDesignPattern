using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repository
{
    public class OrderRepository:EfEntityRepository<Order>,IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
