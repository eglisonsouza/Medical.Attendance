using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Doctor(string name, Guid configId) : BaseEntity
    {
        public string Name { get; private set; } = name;
        public Guid ConfigId { get; private set; } = configId;
        public Config Config { get; private set; }
    }
}
