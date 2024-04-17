using MassTransit;
using Medical.Attendance.Domain.Producers;
using Medical.Attendance.Domain.Repositories;
using Medical.Attendance.Infra.MessageBus.Kafka;
using Medical.Attendance.Infra.MessageBus.Kafka.Messages;
using Medical.Attendance.Infra.MessageBus.Kafka.Producers;
using Medical.Attendance.Infra.Persistence.Configurations.SqlServer;
using Medical.Attendance.Infra.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Smart.Essentials.HealthCheck.SqlServer.DependencyInjection;

namespace Medical.Attendance.Ioc
{
    public static class InfraExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);
            services.AddHealthChecksInfra(configuration);
            services.AddRepositories();
            services.AddKafka();
            return services;
        }

        private static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlServerDbContext>(options =>
                options.UseSqlServer(configuration.GetSection("Settings").GetConnectionString("SqlServerConnection"),
                    b => b.MigrationsAssembly(typeof(SqlServerDbContext).Assembly.FullName)));
        }

        private static void AddHealthChecksInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddHealthChecks()
                .AddSqlServer(configuration.GetSection("Settings").GetConnectionString("SqlServerConnection")!);
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
        }

        private static void AddKafka(this IServiceCollection services)
        {
            services.AddScoped<IMessageProducer<PaymentMessage>, PaymentMessageProducer>();
            services.AddKafkaConfig();
        }

        public static IHost SetupBus(this IHost host)
        {
            var bus = host.Services.GetService<IBusControl>();
            bus.Start();
            return host;
        }
    }
}
