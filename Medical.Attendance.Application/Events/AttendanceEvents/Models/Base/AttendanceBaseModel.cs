using Medical.Attendance.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Models.Base
{
    public class AttendanceBaseModel
    {
        public Guid DoctorId { get; set; }
        public Guid ProceduralMedicalId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string HealthInsurance { get; set; }
        public AttendanceStatus Status { get; set; }
        public decimal Value { get; set; }
    }
}
