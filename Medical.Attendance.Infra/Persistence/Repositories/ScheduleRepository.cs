using Medical.Attendance.Domain.Models.Dtos;
using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Domain.Repositories;
using Medical.Attendance.Infra.Persistence.Configurations.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace Medical.Attendance.Infra.Persistence.Repositories
{
    public class ScheduleRepository(SqlServerDbContext context) : IScheduleRepository
    {
        private readonly SqlServerDbContext _context = context;

        public Task<Config> GetConfigAsync(Guid doctorId)
        {
            return _context.Configs.Include(c => c.WorkDays).FirstAsync(c => c.DoctorId.Equals(doctorId));
        }

        public List<DaysSchedulesDto> GetDaysSchedules(DateTime dateReference, Guid doctorId)
        {
            var attendances = _context.AttendancesMedical.Where(a => a.Start.Month.Equals(dateReference.Month) && a.DoctorId.Equals(doctorId));

            return attendances.Select(a => new DaysSchedulesDto(a.Start, a.GetCalculateDurationInMinutes())).ToList();
        }
    }
}
