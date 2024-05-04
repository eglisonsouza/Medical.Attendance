using MediatR;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.Base;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.InputModels;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Commands
{
    public sealed class AddAttendanceCommand : AttendanceBaseModel, IRequest<AttendanceViewModel>
    {
        public PatientInputModel Patient { get; set; }
    }
}
