using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Domain.Repositories;
using Medical.Attendance.Infra.Persistence.Configurations.SqlServer;

namespace Medical.Attendance.Infra.Persistence.Repositories
{
    public class AttendanceRepository(SqlServerDbContext sqlServerDbContext) : IAttendanceRepository
    {
        public async Task<AttendanceMedical> AddAsync(AttendanceMedical entity, CancellationToken cancellationToken)
        {
            var resultPatient = await sqlServerDbContext.Patients.AddAsync(entity.Patient, cancellationToken);

            var result = await sqlServerDbContext.AttendancesMedical.AddAsync(entity, cancellationToken);

            await sqlServerDbContext.SaveChangesAsync(cancellationToken);

            result.Entity.Patient = resultPatient.Entity;

            return result.Entity;
        }


    }
}
