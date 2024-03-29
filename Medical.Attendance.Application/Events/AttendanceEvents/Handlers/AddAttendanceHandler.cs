using MediatR;
using Medical.Attendance.Application.Events.AttendanceEvents.Commands;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel;
using Medical.Attendance.Infra.Persistence.Configurations;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Handlers
{
    public class AddAttendanceHandler(SqlServerDbContext sqlServerDbContext) : IRequestHandler<AddAttendanceCommand, AttendanceViewModel>
    {
        private readonly SqlServerDbContext _sqlServerDbContext = sqlServerDbContext;

        public async Task<AttendanceViewModel> Handle(AddAttendanceCommand request, CancellationToken cancellationToken)
        {
            var patient = await _sqlServerDbContext.Patients.AddAsync(request.Patient.ToEntity(), cancellationToken);

            var attendance = await _sqlServerDbContext.AttendancesMedical.AddAsync(request.ToEntity(patient.Entity.Id), cancellationToken);

            await _sqlServerDbContext.SaveChangesAsync(cancellationToken);

            return AttendanceViewModel.FromEntity(attendance.Entity, patient.Entity);
        }
    }
}
