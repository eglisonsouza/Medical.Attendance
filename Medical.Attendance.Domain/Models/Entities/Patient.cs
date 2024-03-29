using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Patient : BaseEntity
    {
        public Guid ClientId { get; set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }

        public Patient(Guid clientId, string name, string phone)
        {
            ClientId = clientId;
            Name = name;
            Phone = phone;
        }
    }
}
