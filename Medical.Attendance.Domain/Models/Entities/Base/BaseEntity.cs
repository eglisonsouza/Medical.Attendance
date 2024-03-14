namespace Medical.Attendance.Domain.Models.Entities.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}
