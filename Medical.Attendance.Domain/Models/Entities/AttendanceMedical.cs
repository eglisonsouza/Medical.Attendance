using Medical.Attendance.Domain.Models.Entities.Base;
using Medical.Attendance.Domain.Models.Enums;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class AttendanceMedical : BaseEntity
    {
        public Guid PatientId { get; private set; }
        public Guid DoctorId { get; private set; }
        public Guid ProceduralMedicalId { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public string HealthInsurance { get; private set; }
        public string CancellationDescription { get; private set; }
        public AttendanceStatus Status { get; private set; }
        public Guid TransactionId { get; private set; }
        public decimal Value { get; private set; }
        public Patient Patient { get; private set; }
        public Doctor Doctor { get; private set; }
    }
}
