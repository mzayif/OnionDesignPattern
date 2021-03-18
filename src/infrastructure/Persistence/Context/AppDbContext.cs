using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class AppDbContext :DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Product> Product { get; set; }
    }
}
