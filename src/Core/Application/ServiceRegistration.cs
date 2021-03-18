using System.Reflection;
using Application.Features.Commands.CreateProduct;
using Application.Features.Queries.GetAllProduct;
using Application.Features.Queries.GetByIdProduct;
using Application.Features.Queries.GetWhereProduct;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
