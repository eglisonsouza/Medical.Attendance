using Medical.Attendance.Application.Events.AttendanceEvents.Commands;
using Medical.Attendance.Application.Events.AttendanceEvents.Handlers;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel;
using Medical.Attendance.Application.Events.ConfigEvents.Handlers;
using Medical.Attendance.Application.Events.ScheduleEvents.Handlers;
using Medical.Attendance.Domain.Models.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Medical.Attendance.Ioc
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatRDependencies();
            services.AddMapping();
            return services;
        }

        private static void AddMediatRDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddConfigHandler).GetTypeInfo().Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetConfigHandler).GetTypeInfo().Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddAttendanceHandler).GetTypeInfo().Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetScheduleHandle).GetTypeInfo().Assembly));
        }

        private static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<AddAttendanceCommand, AttendanceMedical>();
                cfg.CreateMap<AttendanceMedical, AttendanceViewModel>();
            });
        }

    }
}
