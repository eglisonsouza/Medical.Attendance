using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Config : BaseEntity
    {
        public bool IsWorkingHolidays { get; private set; }
        public List<Day> WorkDays { get; private set; }
    }
}
