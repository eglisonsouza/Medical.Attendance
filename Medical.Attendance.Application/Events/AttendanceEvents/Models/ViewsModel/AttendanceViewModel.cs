using Medical.Attendance.Application.Events.AttendanceEvents.Models.Base;
using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel
{
    public sealed class AttendanceViewModel : AttendanceBaseModel
    {
        public Guid Id { get; set; }
        public PatientViewModel Patient { get; set; }

        public static AttendanceViewModel FromEntity(AttendanceMedical attendance, Patient patient)
        {
            return new AttendanceViewModel
            {
                Id = attendance.Id,
                DoctorId = attendance.DoctorId,
                ProceduralMedicalId = attendance.ProceduralMedicalId,
                Start = attendance.Start,
                End = attendance.End,
                HealthInsurance = attendance.HealthInsurance,
                Status = attendance.Status,
                Value = attendance.Value,
                Patient = PatientViewModel.FromEntity(patient)
            };
        }
    }
}
