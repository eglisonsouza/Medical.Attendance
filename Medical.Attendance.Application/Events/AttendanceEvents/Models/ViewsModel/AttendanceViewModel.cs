using Medical.Attendance.Application.Events.AttendanceEvents.Models.Base;
using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel
{
    public class AttendanceViewModel : AttendanceBaseModel
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

    public class PatientViewModel : PatientBaseModel
    {
        public Guid Id { get; set; }

        public static PatientViewModel FromEntity(Patient patient)
        {
            return new PatientViewModel
            {
                Id = patient.Id,
                ClientId = patient.ClientId,
                Name = patient.Name,
                Phone = patient.Phone
            };
        }
    }
}
