using Medical.Attendance.Application.Events.AttendanceEvents.Models.Base;
using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel
{
    public sealed class PatientViewModel : PatientBaseModel
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
