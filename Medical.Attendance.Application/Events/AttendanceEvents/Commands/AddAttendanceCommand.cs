using MediatR;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.Base;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel;
using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Domain.Models.Enums;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Commands
{
    public class AddAttendanceCommand : AttendanceBaseModel, IRequest<AttendanceViewModel>
    {

        public PatientInputModel Patient { get; set; }

        public AttendanceMedical ToEntity(Guid patientId)
        {
            return new AttendanceMedical(patientId, DoctorId, ProceduralMedicalId, Start, End, HealthInsurance, Status, Value);
        }
    }

    public class PatientInputModel : PatientBaseModel
    {        
        public Patient ToEntity()
        {
            return new Patient(ClientId, Name, Phone);
        }
    }
}
