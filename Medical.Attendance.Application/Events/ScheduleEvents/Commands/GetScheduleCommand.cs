using MediatR;
using Medical.Attendance.Application.Events.ScheduleEvents.Models.ViewsModel;

namespace Medical.Attendance.Application.Events.ScheduleEvents.Commands
{
    public class GetScheduleCommand : IRequest<ScheduleViewModel>
    {
        public DateTime StartMonth { get; set; }
        public Guid DoctorId { get; set; }
    }
}
