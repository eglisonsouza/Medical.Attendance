using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Domain.Repositories
{
    public interface IAttendanceRepository
    {
        Task<AttendanceMedical> AddAsync(AttendanceMedical entity, CancellationToken cancellationToken);
    }
}
