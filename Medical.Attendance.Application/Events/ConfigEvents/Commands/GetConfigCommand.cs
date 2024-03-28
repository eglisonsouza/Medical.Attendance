using MediatR;
using Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel;

namespace Medical.Attendance.Application.Events.ConfigEvents.Commands
{
    public class GetConfigCommand : IRequest<ConfigViewModel>
    {
        public Guid DoctorId { get; set; }
    }
}
