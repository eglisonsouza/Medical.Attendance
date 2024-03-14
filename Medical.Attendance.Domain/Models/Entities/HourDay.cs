using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class HourDay(DateTime hour, int sequential, Guid dayId) : BaseEntity
    {
        public DateTime Hour { get; private set; } = hour;
        public int Sequential { get; private set; } = sequential;
        public Guid DayId { get; private set; } = dayId;
        public Day Day { get; private set; }

    }
}
