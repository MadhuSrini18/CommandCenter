using CommandCenter.Application.Persistence.IServices;
using CommandCenter.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CommandCenter.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            RegisterBussinessManagers(services);
            return services;
        }

        public static void RegisterBussinessManagers(IServiceCollection services)
        {
            services.AddSingleton<ISignalRService, SignalRService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
