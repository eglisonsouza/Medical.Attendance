using MediatR;
using Medical.Attendance.Application.Events.ConfigEvents.Models.InputsModel;
using Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel;

namespace Medical.Attendance.Application.Events.ConfigEvents.Commands
{
    public class AddConfigCommand : IRequest<ConfigViewModel>
    {
        public DoctorInputModel Doctor { get; set; }
        public bool IsWorkingHolidays { get; set; }
        public List<DayInputModel> Days { get; set; }
    }
}
