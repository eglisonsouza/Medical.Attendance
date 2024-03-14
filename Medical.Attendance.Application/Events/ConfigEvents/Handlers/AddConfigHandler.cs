using MediatR;
using Medical.Attendance.Application.Events.ConfigEvents.Commands;
using Medical.Attendance.Application.Events.ConfigEvents.Models.InputsModel;
using Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel;
using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.Configurations;

namespace Medical.Attendance.Application.Events.ConfigEvents.Handlers
{
    public class AddConfigHandler(SqlServerDbContext sqlServerDbContext) : IRequestHandler<AddConfigCommand, ConfigViewModel>
    {
        private readonly SqlServerDbContext _sqlServerDbContext = sqlServerDbContext;
        private readonly ConfigViewModel _configViewModel = new();

        public async Task<ConfigViewModel> Handle(AddConfigCommand request, CancellationToken cancellationToken)
        {
            await AddConfig(request, cancellationToken);

            await AddDoctor(request.Doctor, cancellationToken);

            await AddDays(request.Days, cancellationToken);

            _sqlServerDbContext.SaveChanges();

            return _configViewModel;
        }

        private async Task AddConfig(AddConfigCommand request, CancellationToken cancellationToken)
        {
            var result = await _sqlServerDbContext.Configs.AddAsync(new Config(request.IsWorkingHolidays), cancellationToken);

            _configViewModel.SetConfigFromEntity(result.Entity);
        }

        private async Task AddDoctor(DoctorInputModel request, CancellationToken cancellationToken)
        {
            var result = await _sqlServerDbContext.Doctors.AddAsync(new Doctor(request.Name, _configViewModel.Id), cancellationToken);

            _configViewModel.SetDoctorFromEntity(result.Entity);
        }
        private async Task AddDays(List<DayInputModel> days, CancellationToken cancellationToken)
        {
            foreach (var dayRequest in days)
            {
                var result = await _sqlServerDbContext.Days.AddAsync(new Day(dayRequest.DayName, dayRequest.Sequential, _configViewModel.Id), cancellationToken);

                _configViewModel.AddDayFromEntity(result.Entity);

                await AddHourFromDay(dayRequest.Hours, result.Entity.Id, cancellationToken);
            }
        }

        private async Task AddHourFromDay(List<HourInputModel> hours, Guid dayId, CancellationToken cancellationToken)
        {
            foreach (var hour in hours)
            {
                var result = await _sqlServerDbContext.HoursDays.AddAsync(new HourDay(hour.Hour, hour.Sequential, dayId), cancellationToken);

                _configViewModel.Days.Single(d => d.Id.Equals(dayId)).SetHoursFromEntity(result.Entity);
            }
        }
    }
}
