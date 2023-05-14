using CommandCenter.Infrastrucutre.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CommandCenter.Application.Persistence.Data;
using CommandCenter.Infrastrucutre.Repository;
using CommandCenter.Application.Persistence.IRespositories;

namespace CommandCenter.Infrastrucutre
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterRepositories(services);

            RegisterServices(services, configuration);

            return services;
        }
        private static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            // Unit Of Work
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            return services;
        }
        private static IServiceCollection RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            string sqlServerConnectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<FlightDBContext>(options => options.UseSqlServer(sqlServerConnectionString));

            services.AddScoped<IFlightDBContext>(provider => provider.GetRequiredService<FlightDBContext>());

            return services;
        }
    }
}