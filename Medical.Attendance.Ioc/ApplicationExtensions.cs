using Medical.Attendance.Application.Events.ConfigEvents.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Medical.Attendance.Ioc
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatRDependencies();
            return services;
        }

        private static void AddMediatRDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddConfigHandler).GetTypeInfo().Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetConfigHandler).GetTypeInfo().Assembly));
        }


    }
}
