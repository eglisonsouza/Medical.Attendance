using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Day(string dayName, int sequential, Guid configId) : BaseEntity
    {
        public string DayName { get; private set; } = dayName;
        public int Sequential { get; private set; } = sequential;
        public Guid ConfigId { get; private set; } = configId;
        public List<HourDay> Hours { get; private set; }
        public Config Config { get; private set; }
    }
}
