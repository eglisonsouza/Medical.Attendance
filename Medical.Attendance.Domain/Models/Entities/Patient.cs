using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Patient : BaseEntity
    {
        public Guid ClientId { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
    }
}
