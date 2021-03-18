using Application.Interfaces;
using Application.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace productEx.infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddTransient<IEmailService, EmailService>();
        }
    }
}
