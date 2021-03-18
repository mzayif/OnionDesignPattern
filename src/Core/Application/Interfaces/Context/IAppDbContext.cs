using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces.Context
{
    public interface IAppDbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
