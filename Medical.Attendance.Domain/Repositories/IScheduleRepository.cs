using Medical.Attendance.Domain.Models.Dtos;
using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Domain.Repositories
{
    public interface IScheduleRepository
    {
        Task<Config> GetConfigAsync(Guid doctorId);
        List<DaysSchedulesDto> GetDaysSchedules(DateTime dateReference, Guid doctorId);
    }
}
