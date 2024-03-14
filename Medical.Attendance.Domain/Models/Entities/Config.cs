using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Config(bool isWorkingHolidays) : BaseEntity
    {
        public bool IsWorkingHolidays { get; private set; } = isWorkingHolidays;
        public List<Day> WorkDays { get; private set; }
    }
}
