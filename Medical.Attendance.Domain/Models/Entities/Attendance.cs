using Medical.Attendance.Domain.Models.Entities.Base;
using Medical.Attendance.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Attendance : BaseEntity
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
    }
}
