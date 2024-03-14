using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Doctor : BaseEntity
    {
        public string Name { get; private set; }
        public Config Config { get; private set; }
        public Guid ConfigId { get; private set; }
    }
}
