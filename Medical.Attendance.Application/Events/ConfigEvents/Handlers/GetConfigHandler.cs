using MediatR;
using Medical.Attendance.Application.Events.ConfigEvents.Commands;
using Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel;
using Medical.Attendance.Infra.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Medical.Attendance.Application.Events.ConfigEvents.Handlers
{
    public sealed class GetConfigHandler(SqlServerDbContext sqlServerDbContext) : IRequestHandler<GetConfigCommand, ConfigViewModel>
    {
        private readonly SqlServerDbContext _sqlServerDbContext = sqlServerDbContext;
        private readonly ConfigViewModel _configViewModel = new();

        public async Task<ConfigViewModel> Handle(GetConfigCommand request, CancellationToken cancellationToken)
        {
            await GetDoctor(request, cancellationToken);

            await GetConfig(cancellationToken);

            _configViewModel.Days.ForEach(async d => d.Hours.AddRange(await GetHours(d.Id, cancellationToken)));

            return _configViewModel;
        }

        private async Task GetConfig(CancellationToken cancellationToken)
        {
            var config = await _sqlServerDbContext.Configs.Include(c => c.WorkDays).FirstOrDefaultAsync(d => d.Id.Equals(_configViewModel.Id), cancellationToken: cancellationToken);

            _configViewModel.SetConfigFromEntity(config!);

            _configViewModel.AddDayFromEntity(config!.WorkDays);
        }

        private async Task GetDoctor(GetConfigCommand request, CancellationToken cancellationToken)
        {
            var doctor = await _sqlServerDbContext.Doctors.FirstOrDefaultAsync(d => d.Id.Equals(request.DoctorId), cancellationToken: cancellationToken);

            _configViewModel.SetDoctorFromEntity(doctor!);
        }

        private async Task<List<HourViewModel>> GetHours(Guid id, CancellationToken cancellationToken)
        {
            var hours = await _sqlServerDbContext.HoursDays.Where(h => h.DayId.Equals(id)).ToListAsync(cancellationToken);
            return hours.Select(HourViewModel.FromEntity).ToList();
        }
    }
}
