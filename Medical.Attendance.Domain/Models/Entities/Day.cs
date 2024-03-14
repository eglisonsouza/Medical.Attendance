using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Day : BaseEntity
    {
        public string DayName { get; private set; }
        public int Sequencial { get; private set; }
        public List<HourDay> Hours { get; private set; }
        public Guid ConfigId { get; private set; }
        public Config Config { get; private set; }
    }
}
